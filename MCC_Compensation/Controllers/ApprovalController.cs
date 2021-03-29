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
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ApprovalController : BaseController<Approval, ApprovalRepository, int>
    {
        private readonly IConfiguration _configuration;
        private readonly ApprovalRepository _approvalRepository;

        public ApprovalController(ApprovalRepository approvalRepository, IConfiguration configuration) : base(approvalRepository)
        {
            _approvalRepository = approvalRepository;
            _configuration = configuration;
        }

        [HttpGet("ApprovalStatus")]
        public IActionResult ApprovalStatus(int RequestID)
        {
            ResponseVM<IEnumerable<RequestStatusVM>> responseContent = new ResponseVM<IEnumerable<RequestStatusVM>>();
            var result = _approvalRepository.ApprovalStatus(RequestID);

            if (result != null)
            {
                responseContent.Status = ResponseVM<IEnumerable<RequestStatusVM>>.StatusType.Success;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<IEnumerable<RequestStatusVM>>.StatusType.Failed;
                responseContent.Message = "Data not found";
                return StatusCode(500, responseContent);
            }
        }
    }
}
