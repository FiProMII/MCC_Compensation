using API.Base.Controller;
using API.Models;
using API.Repository.Data;
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
        private readonly CompensationRequestRepository _requestRepository;
        private readonly IConfiguration _configuration;

        public CompensationRequestController(CompensationRequestRepository compensationRequestRepository, IConfiguration configuration) : base(compensationRequestRepository)
        {
            _requestRepository = compensationRequestRepository;
            _configuration = configuration;
        }

        [HttpGet("Request")]
        public IActionResult CompensationRequest()
        {
            var result = _requestRepository.Request();

            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result, message = "Data Found" });
            }
            else
            {
                return NotFound(new { status = HttpStatusCode.NotFound, message = "Data Not Found", result = "" });
            }
        }
    }
}
