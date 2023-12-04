using EEEE_DataAccess.Consts;
using EEEE_DataAccess.Repositories;
using EEEE_Domain.Models;
using EEEE_Domain.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EEEE_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcuseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly RoleManager<IdentityRole> roleManager;


        public ExcuseController(IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            this.roleManager = roleManager;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _unitOfWork.Excuses.GetAllAsync());
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(EmployeeExcuseModel excuse)
        {
            if (ModelState.IsValid)
            {
                Excuses NewExcuse = new Excuses();
                NewExcuse.Name = excuse.Name;
                NewExcuse.Type = excuse.Type;
                NewExcuse.Description = excuse.Description;
                NewExcuse.StartDate = excuse.StartDate;
                NewExcuse.EndDate = excuse.EndDate;
                NewExcuse.ExcuseStatus = 1;
                NewExcuse.ExcuseStatusComment = "Waiting for Manager Comment";
                await _unitOfWork.Excuses.AddAsync(NewExcuse);

                await _unitOfWork.CompleteAsync();

                return Ok(_unitOfWork.Excuses.AddAsync(NewExcuse));

            }
            return BadRequest();
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme ,Roles = "Manager")]
        [HttpPut("PutExcuse")]
        public async Task<IActionResult> PutExcuse([FromBody]ManagerExcuseModel excuse, [FromHeader]int excuseId)
        {
            if (ModelState.IsValid) 
            {
                var checkExcuse = await _unitOfWork.Excuses.GetByIdAsync(excuseId);
                if(checkExcuse != null)
                {
                    //Excuses NewExcuse = new Excuses();
                    checkExcuse.ExcuseStatus = excuse.ExcuseStatus;
                    checkExcuse.ExcuseStatusComment = excuse.ExcuseStatusComment;
                    await _unitOfWork.CompleteAsync();

                    return Ok(_unitOfWork.Excuses.UpdateAsync(checkExcuse));
                }

            }
            return BadRequest();
        }


    }
}
