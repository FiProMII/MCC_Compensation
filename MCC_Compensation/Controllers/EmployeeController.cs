using API.Base.Controller;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : BaseController<Employee, EmployeeRepository, string>
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly IConfiguration _configuration;

        public EmployeeController(EmployeeRepository employeeRepository, IConfiguration configuration) : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _configuration = configuration;
        }

        [HttpPost]
        public override ActionResult Post(Employee employee)
        {
            ResponseVM<Employee> responseContent = new ResponseVM<Employee>();

            if (employee == null)
            {
                responseContent.Status = ResponseVM<Employee>.StatusType.Failed;
                responseContent.Message = "The data entered is incomplete or incorrect";
                return BadRequest(responseContent);
            }

            Account account = new Account();
            account.NIK = employee.NIK;
            account.Password = BC.EnhancedHashPassword("default");
            employee.Account = account;
            var result = _employeeRepository.Insert(employee);

            if (result > 0)
            {
                responseContent.Status = ResponseVM<Employee>.StatusType.Success;
                responseContent.Message = "Data created successfully";
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<Employee>.StatusType.Failed;
                responseContent.Message = "Unable to create new data";
                return StatusCode(500, responseContent);
            }
        }

        [HttpPost("Validation")]
        public IActionResult Validation(string Params)
        {
            var result = _employeeRepository.Validation(Params);
            ResponseVM<string> responseContent = new ResponseVM<string>();
            if (result != null)
            {
                responseContent.Status = ResponseVM<string>.StatusType.Success;
                responseContent.Message = "Sign In successful";
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<string>.StatusType.Failed;
                responseContent.Message = "Sign in failed";
                return BadRequest(responseContent);
            }
        }
    }
}
