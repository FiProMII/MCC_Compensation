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

        [HttpPost("Validation")]
        public IActionResult Validation(string Params)
        {
            var result = _employeeRepository.Validation(Params);
            ResponseVM<string> responseContent = new ResponseVM<string>();
            if (result != null)
            {
                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Sign In successful";
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.NotFound;
                responseContent.Message = "Sign in failed";
                return BadRequest(responseContent);
            }
        }
    }
}
