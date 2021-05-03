using API.Base.Controller;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RoleController : BaseController<Role, RoleRepository, int>
    {
        private readonly RoleRepository _roleRepository;
        public RoleController(RoleRepository roleRepository) : base(roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public override ActionResult<Role> Get()
        {
            ResponseVM<IEnumerable<Role>> responseContent = new ResponseVM<IEnumerable<Role>>();
            var result = _roleRepository.GetList();

            if (result != null)
            {
                responseContent.Status = ResponseVM<IEnumerable<Role>>.StatusType.Success;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<IEnumerable<Role>>.StatusType.Failed;
                responseContent.Message = "Something went wrong";
                return StatusCode(500, responseContent);
            }
        }
    }
}
