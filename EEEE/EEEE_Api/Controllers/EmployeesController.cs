using EEEE_Domain.Models;
using EEEE_Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EEEE_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IGenericRepository<Employee> _employeeRepository;
        public EmployeesController(IGenericRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        [HttpGet]
        public IActionResult GetById() 
        {
            return Ok(_employeeRepository.GetById(1));
        }


    }
}
