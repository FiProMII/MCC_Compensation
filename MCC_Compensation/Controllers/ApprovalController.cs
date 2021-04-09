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
            if (result != null)
            {
                responseContent.Status = ResponseVM<Approval>.StatusType.Success;
                responseContent.Message = "Data was updated";

                EmailController emailController = new EmailController(_hostingEnvironment);
                try
                {
                    
                    if (User.IsInRole("Finance") && updateStatusVM.StatusName.ToLower().Contains("approve"))
                    {
                        var employees = GetRecipients(result.NIK);
                        emailController.SendEmail(EmailController.EmailType.CompensationRequestApproved, employees.FirstOrDefault(), result);
                    }
                    else if (updateStatusVM.StatusName.ToLower().Contains("reject"))
                    {
                        var employees = GetRecipients(result.NIK);
                        emailController.SendEmail(EmailController.EmailType.CompensationRequestRejected, employees.FirstOrDefault(), result);
                    }
                    else
                    {
                        var employees = GetRecipients(null);
                        foreach (var employee in employees)
                        {
                            emailController.SendEmail(EmailController.EmailType.CompensationRequest, employee, result);
                        }
                    }
                    
                    return Ok(responseContent);
                }
                catch
                {
                    responseContent.Status = ResponseVM<Approval>.StatusType.Failed;
                    responseContent.Message = "Email is not sent";
                    return StatusCode(500, responseContent);
                }
            }
            else
            {
                responseContent.Status = ResponseVM<Approval>.StatusType.Failed;
                responseContent.Message = "Data was not updated";
                return StatusCode(500, responseContent);
            }
        }

        public IEnumerable<Employee> GetRecipients(string requestNIK)
        {
            IEnumerable<Employee> employees = Enumerable.Empty<Employee>();
            if (User.IsInRole("RM") && requestNIK == null)
            {
                employees = _approvalRepository.GetRecipients(1, null);
            }
            else if (User.IsInRole("HR") && requestNIK == null)
            {
                employees = _approvalRepository.GetRecipients(2, null);
            }
            else
            {
                employees = _approvalRepository.GetRecipients(3, requestNIK);
            }
            return employees;
        }
    }
}
