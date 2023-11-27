using EEEE_DataAccess.Repositories;
using EEEE_Domain.Models;
using EEEE_Domain.Repositories;
using EEEE_Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace EEEE_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public EmployeesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        [Route("PostEmployee")]

        public IActionResult PostEmployee(Employee employee)
        {
            if (ModelState == null)
            {

            }
            return Ok(_unitOfWork.Employees.AddAsync(employee));
        }


        [HttpPost]
        [Route("CreateNewEmp")]

        public async Task<IActionResult> CreateNewEmp(EmployeeModel employee)
        {

            if (ModelState.IsValid)
            {
                Employee newEmp = new Employee();
                newEmp.Name = employee.Name;
                newEmp.Email = employee.Email;
                newEmp.Age = employee.Age;
                newEmp.Gener = employee.Gener;
                newEmp.DateOfBirth = employee.DateOfBirth;
                newEmp.CurrentAddress = employee.CurrentAddress;
                newEmp.PerminentAddress = employee.PerminentAddress;
                newEmp.PostalCode = employee.PostalCode;
                newEmp.PhoneNumber = employee.PhoneNumber;
                newEmp.EmargancyContact = employee.EmargancyContact;
                newEmp.NetSalary = employee.NetSalary;
                newEmp.Email = employee.Email;
                await _unitOfWork.Employees.AddAsync(newEmp);

                await _unitOfWork.CompleteAsync();

                return Ok();






            }
            return BadRequest();
        }


    }
}
