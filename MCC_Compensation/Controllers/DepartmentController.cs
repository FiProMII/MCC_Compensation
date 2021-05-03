using API.Base.Controller;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DepartmentController : BaseController<Department, DepartmentRepository, int>
    {
        private readonly DepartmentRepository _departmentRepository;
        public DepartmentController(DepartmentRepository departmentRepository) : base(departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public override ActionResult<Department> Get()
        {
            ResponseVM<IEnumerable<Department>> responseContent = new ResponseVM<IEnumerable<Department>>();
            var result = _departmentRepository.GetList();

            if (result != null)
            {
                responseContent.Status = ResponseVM<IEnumerable<Department>>.StatusType.Success;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<IEnumerable<Department>>.StatusType.Failed;
                responseContent.Message = "Something went wrong";
                return StatusCode(500, responseContent);
            }
        }
    }
}
