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
    public class DasboardController : ControllerBase
    {
        private readonly DashboardRepository _dashboardRepository;
        private readonly IConfiguration _configuration;

        public DasboardController(DashboardRepository dashboardRepository, IConfiguration configuration)
        {
            _dashboardRepository = dashboardRepository;
            _configuration = configuration;
        }

        [HttpGet("Chart")]
        [EnableCors("AllowOrigin")]
        public IActionResult Chart()
        {
            var result = _dashboardRepository.Chart();

            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result, message = "Data found" });
            }
            else
            {
                return NotFound(new { status = HttpStatusCode.NotFound, message = "Data not found", result = "" });
            }
        }
    }
}
