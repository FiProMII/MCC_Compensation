using API.Base.Controller;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Cors;
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

    public class CompensationRequestController : BaseController<CompensationRequest, CompensationRequestRepository, int>
    {
        private readonly IConfiguration _configuration;
        private readonly CompensationRequestRepository _compensationRequestRepository;

        public CompensationRequestController(CompensationRequestRepository compensationRequestRepository, IConfiguration configuration) : base(compensationRequestRepository)
        {
            _compensationRequestRepository = compensationRequestRepository;
            _configuration = configuration;
        }

        public override ActionResult Post(CompensationRequest compensationRequest)
        {
            ResponseVM<CompensationRequest> responseContent = new ResponseVM<CompensationRequest>();

            if (compensationRequest == null)
            {
                responseContent.Status = ResponseVM<CompensationRequest>.StatusType.Failed;
                responseContent.Message = "The data entered is incomplete or incorrect";
                return BadRequest(responseContent);
            }

            var result = _compensationRequestRepository.Insert(compensationRequest);

            if (result > 0)
            {
                responseContent.Status = ResponseVM<CompensationRequest>.StatusType.Success;
                responseContent.Message = "Data created successfully";
                //EmailController emailController = new EmailController();
                //emailController.SendEmail("tes", EmailController.EmailType.CompensationRequest, "a");
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<CompensationRequest>.StatusType.Failed;
                responseContent.Message = "Unable to create new data";
                return StatusCode(500, responseContent);
            }
        }

        public IEnumerable<string> GetRecipientEmails()
        {
            IEnumerable<string> emails = Enumerable.Empty<string>();
            return emails;
        }

        [HttpGet("RequestList")]
        public IActionResult RequestList(string Status, string Information)
        {
            ResponseVM<IEnumerable<RequestListVM>> responseContent = new ResponseVM<IEnumerable<RequestListVM>>();
            var result = _compensationRequestRepository.RequestList(Status, Information);

            if (result != null)
            {
                responseContent.Status = ResponseVM<IEnumerable<RequestListVM>>.StatusType.Success;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<IEnumerable<RequestListVM>>.StatusType.Failed;
                responseContent.Message = "Data not found";
                return StatusCode(500, responseContent);
            }
        }
    }
}
