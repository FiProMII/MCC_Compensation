using API.Repository.Data;
using Microsoft.AspNetCore.Authorization;
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
    [AllowAnonymous]
    public class DashboardController : ControllerBase
    {
        private readonly DashboardRepository _dashboardRepository;
        private readonly IConfiguration _configuration;
        public DashboardController(DashboardRepository dashboardRepository, IConfiguration configuration)
        {
            _dashboardRepository = dashboardRepository;
            _configuration = configuration;
        }

        [EnableCors("AllowOrigin")]
        [HttpGet("Chart")]
        [AllowAnonymous]
        public IActionResult Chart()
        {
            var result = _dashboardRepository.Chart();

            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result, message = "Data Ditemukan" });
            }
            else
            {
                return NotFound(new { status = HttpStatusCode.NotFound, message = "Data Tidak Ditemukan", result = "" });
            }
        }
    }
}
