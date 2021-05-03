using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class PositionController : BaseController<Position, int>
    {
        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
            var response = await httpClient.GetAsync("Position/GetPosition");
            var apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<IEnumerable<PositionListVM>>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }
    }
}