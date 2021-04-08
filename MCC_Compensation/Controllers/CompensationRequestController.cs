using API.Base.Controller;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
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
        private IWebHostEnvironment _hostingEnvironment;

        public CompensationRequestController(CompensationRequestRepository compensationRequestRepository, IConfiguration configuration, IWebHostEnvironment hostingEnvironment) : base(compensationRequestRepository)
        {
            _compensationRequestRepository = compensationRequestRepository;
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
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

            var result = _compensationRequestRepository.InsertRequest(compensationRequest);

            if (result.RequestID > 0)
            {
                responseContent.Status = ResponseVM<CompensationRequest>.StatusType.Success;
                responseContent.Message = "Data created successfully";
                
                EmailController emailController = new EmailController(_hostingEnvironment);
                try
                {
                    var nik = User.FindFirst("NIK").Value;
                    var manager = _compensationRequestRepository.GetManager(nik);
                    emailController.SendEmail(EmailController.EmailType.CompensationRequest, manager, result);
                } catch
                {
                    responseContent.Status = ResponseVM<CompensationRequest>.StatusType.Failed;
                    responseContent.Message = "Email is not sent";
                    return StatusCode(500, responseContent);
                }
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<CompensationRequest>.StatusType.Failed;
                responseContent.Message = "Unable to create new data";
                return StatusCode(500, responseContent);
            }
        }

        [HttpGet("GetDetail")]
        public IActionResult GetDetail(int RequestID)
        {
            ResponseVM<DetailRequestVM> responseContent = new ResponseVM<DetailRequestVM>();
            var result = _compensationRequestRepository.GetDetailRequest(RequestID);

            if (result != null)
            {
                responseContent.Status = ResponseVM<DetailRequestVM>.StatusType.Success;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<DetailRequestVM>.StatusType.Failed;
                responseContent.Message = "Data not found";
                return StatusCode(500, responseContent);
            }
        }

        [HttpGet("RequestList")]
        public IActionResult RequestList(string Status, string NIK)
        {
            ResponseVM<IEnumerable<RequestListVM>> responseContent = new ResponseVM<IEnumerable<RequestListVM>>();
            var result = _compensationRequestRepository.RequestList(Status, NIK);

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

        [HttpGet("RequestByDepartmentList")]
        public IActionResult GetRequestsByDepartment()
        {
            ResponseVM<IEnumerable<CompensationRequest>> responseContent = new ResponseVM<IEnumerable<CompensationRequest>>();
            var nik = User.FindFirst("NIK").Value;
            var result = _compensationRequestRepository.GetRequestsByDepartment(nik);

            if (result != null)
            {
                responseContent.Status = ResponseVM<IEnumerable<CompensationRequest>>.StatusType.Success;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<IEnumerable<CompensationRequest>>.StatusType.Failed;
                responseContent.Message = "Data not found";
                return StatusCode(500, responseContent);
            }
        }
    }
}
