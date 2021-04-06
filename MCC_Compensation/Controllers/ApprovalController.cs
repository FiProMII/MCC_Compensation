using API.Base.Controller;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Hosting;
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
        private IWebHostEnvironment _hostingEnvironment;

        public ApprovalController(ApprovalRepository approvalRepository, IConfiguration configuration, IWebHostEnvironment hostingEnvironment) : base(approvalRepository)
        {
            _approvalRepository = approvalRepository;
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
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

        [HttpPut("UpdateApprovalStatus")]
        public IActionResult UpdateApprovalStatus(UpdateStatusVM updateStatusVM)
        {
            ResponseVM<Approval> responseContent = new ResponseVM<Approval>();
            var result = _approvalRepository.UpdateApprovalStatus(updateStatusVM);

            if (result > 0)
            {
                responseContent.Status = ResponseVM<Approval>.StatusType.Success;
                responseContent.Message = "Data was updated";

                EmailController emailController = new EmailController(_hostingEnvironment);
                try
                {
                    var emails = GetRecipientEmails();
                    foreach (var email in emails)
                    {
                        emailController.SendEmail(email, EmailController.EmailType.CompensationRequest, result.ToString());
                    }
                }
                catch
                {
                    responseContent.Status = ResponseVM<Approval>.StatusType.Failed;
                    responseContent.Message = "Email is not sent";
                    return StatusCode(500, responseContent);
                }

                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<Approval>.StatusType.Failed;
                responseContent.Message = "Data was not updated";
                return StatusCode(500, responseContent);
            }
        }

        public IEnumerable<string> GetRecipientEmails()
        {
            var nik = User.FindFirst("NIK").Value;
            IEnumerable<string> emails = Enumerable.Empty<string>();
            if (User.IsInRole("RM"))
            {
                emails = _approvalRepository.GetRecipientEmails(1, nik);
            }
            else if (User.IsInRole("HR"))
            {
                emails = _approvalRepository.GetRecipientEmails(2, nik);
            }
            return emails;
        }
    }
}
