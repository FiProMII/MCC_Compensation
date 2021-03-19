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
        public CompensationRequestController(CompensationRequestRepository compensationRequestRepository) : base(compensationRequestRepository)
        {
            
        }
    }
}
