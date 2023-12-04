using Azure;
using EEEE_DataAccess.Context;
using EEEE_DataAccess.Repositories;
using EEEE_Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EEEE_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly IConfiguration configuration;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public AuthenticationController(IConfiguration configuration,
                                        UserManager<ApplicationUser> userManager, 
                                        RoleManager<IdentityRole> roleManager)
        {
            this.configuration = configuration;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.UserName);
            if (ModelState.IsValid && (userExists == null))
            {
                ApplicationUser user = new ApplicationUser();

                user.Email = model.Email;
                user.SecurityStamp = Guid.NewGuid().ToString();
                user.UserName = model.UserName;
                IdentityResult result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    var EmployeeRoleExists = await roleManager.FindByNameAsync("Employee");
                    if (EmployeeRoleExists != null)
                    {
                        IdentityResult roleAddedResult = await userManager.AddToRoleAsync(user, EmployeeRoleExists.Name);
                        if (roleAddedResult.Succeeded)
                        {
                            return new JsonResult(new { success = true, message = "User Registered successfully." });

                        }
                        return new JsonResult(new { success = false, message = $"Can't Assgin role to {user}" });
                    }

                    IdentityRole role = new IdentityRole();

                    role.Name = "Employee";
                    role.ConcurrencyStamp = Guid.NewGuid().ToString();
                    IdentityResult roleResult = await roleManager.CreateAsync(role);
                    IdentityResult roleCreatedAddedResult = await userManager.AddToRoleAsync(user, role.Name);
                    if (roleCreatedAddedResult.Succeeded)
                    {
                        return new JsonResult(new { success = true, message = "User Registered successfully." });

                    }

                }



                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return BadRequest(ModelState);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.Expiration, DateTime.UtcNow.ToString())
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }

            return BadRequest();
            //return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "User doesn't exist!" });
        }

        [HttpPost("AssginRole")]
        public async Task<IActionResult> AssignRole([FromBody] AssignModel user)
        {
            ApplicationUser userExists = await userManager.FindByNameAsync(user.UserToAssign);
            if (userExists != null)
            {                

                var EmployeeRoleExists = await roleManager.FindByNameAsync("Manager");
                if (EmployeeRoleExists != null)
                {
                    IdentityResult roleAddedResult = await userManager.AddToRoleAsync(userExists, EmployeeRoleExists.Name);
                    if (roleAddedResult.Succeeded)
                    {
                        return new JsonResult(new { success = true, message = "User Assigned successfully." });

                    }
                    return new JsonResult(new { success = false, message = $"Can't Assgin role to {userExists}" });
                }

                IdentityRole role = new IdentityRole();

                role.Name = "Manager";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();
                IdentityResult roleResult = await roleManager.CreateAsync(role);
                IdentityResult roleCreatedAddedResult = await userManager.AddToRoleAsync(userExists, role.Name);
                if (roleCreatedAddedResult.Succeeded)
                {
                    return new JsonResult(new { success = true, message = "User Assigned successfully." });

                }
            }
            return BadRequest();
        }

        #region GenerateToken
        //public string GenerateToken(ApplicationUser user, IdentityUser role)
        //{
        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key")); // Replace with your own key
        //    var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //    var authClaims = new List<Claim>
        //    {
        //        new Claim(ClaimTypes.Name, user.UserName),
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //        new Claim(ClaimTypes.Role, role.UserName)
        //    };

        //    var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

        //    var token = new JwtSecurityToken(
        //        issuer: configuration["JWT:ValidIssuer"],
        //        audience: configuration["JWT:ValidAudience"],
        //        expires: DateTime.Now.AddHours(3),
        //        claims: authClaims,
        //        signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        //        );

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}
        #endregion

        #region register admin
        //[HttpPost]
        //[Route("register-admin")]
        //public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        //{
        //    var userExists = await userManager.FindByNameAsync(model.Username);
        //    if (userExists != null)
        //        return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "User already exists!" });

        //    ApplicationUser user = new ApplicationUser()
        //    {
        //        Email = model.Email,
        //        SecurityStamp = Guid.NewGuid().ToString(),
        //        UserName = model.Username
        //    };
        //    var result = await userManager.CreateAsync(user, model.Password);
        //    if (!result.Succeeded)
        //        return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

        //    if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //        await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //    if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //        await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //    if (await roleManager.RoleExistsAsync(UserRoles.Admin))
        //    {
        //        await userManager.AddToRoleAsync(user, UserRoles.Admin);
        //    }

        //    return Ok(new Response { Status = "Success", Message = "Admin Registered successfully!" });
        //}
        #endregion

        #region delete user
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUser(string id)
        //{
        //    var user = await userManager.FindByIdAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    await userManager.DeleteAsync(user);

        //    return Ok();
        //}

        #endregion

    }
}
