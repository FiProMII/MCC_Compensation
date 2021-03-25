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

        private readonly CompensationRequestRepository _compensationRequestRepository;

        public CompensationRequestController(CompensationRequestRepository compensationRequestRepository) : base(compensationRequestRepository)
        {
            _compensationRequestRepository = compensationRequestRepository;
        }

        public override ActionResult Post(CompensationRequest compensationRequest)
        {
            ResponseVM<CompensationRequest> responseContent = new ResponseVM<CompensationRequest>();

            if (compensationRequest == null)
            {
                responseContent.Status = HttpStatusCode.BadRequest;
                responseContent.Message = "The data entered is incomplete or incorrect";
                return BadRequest(responseContent);
            }

            var result = _compensationRequestRepository.Insert(compensationRequest);

            if (result > 0)
            {
                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Data created successfully";
                EmailController emailController = new EmailController();
                emailController.SendEmail("tes", EmailController.EmailType.CompensationRequest, "a");
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.InternalServerError;
                responseContent.Message = "Unable to create new data";
                return StatusCode(500, responseContent);
            }
        }

        public IEnumerable<string> GetRecipientEmails()
        {
            IEnumerable<string> emails = Enumerable.Empty<string>();
            return emails;
        }
    }
}
