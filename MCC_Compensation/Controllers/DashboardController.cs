using API.Base.Controller;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net;

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
            var result = _dashboardRepository.Chart("CompensationID");

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
