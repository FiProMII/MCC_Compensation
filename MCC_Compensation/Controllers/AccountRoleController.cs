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
using System.Net;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AccountRoleController : BaseController<AccountRole, AccountRoleRepository, string>
    {
        private readonly AccountRoleRepository _accountRoleRepository;
        private readonly IConfiguration _configuration;

        public AccountRoleController(AccountRoleRepository accountRoleRepository, IConfiguration configuration) : base(accountRoleRepository)
        {
            _accountRoleRepository = accountRoleRepository;
            _configuration = configuration;
        }

        [HttpGet("{key}")]
        public override ActionResult<AccountRole> Get(string key)
        {
            ResponseVM<IEnumerable<AccountRole>> responseContent = new ResponseVM<IEnumerable<AccountRole>>();
            var result = _accountRoleRepository.GetAccountRoleByID(key);

            if (result != null)
            {
                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.InternalServerError;
                responseContent.Message = "Something went wrong";
                return StatusCode(500, responseContent);
            }
        }

        [HttpDelete("{key}")]
        public override ActionResult Delete(string key)
        {
            ResponseVM<AccountRole> responseContent = new ResponseVM<AccountRole>();

            if (key == null)
            {
                responseContent.Status = HttpStatusCode.BadRequest;
                responseContent.Message = "The request is incomplete or incorrect";
                return BadRequest(responseContent);
            }

            var result = _accountRoleRepository.DeleteAccountRoleByID(key);

            if (result > 0)
            {
                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Data deleted successfully";
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.NotFound;
                responseContent.Message = "Nothing changed";
                return Ok(responseContent);
            }
        }
    }
}
