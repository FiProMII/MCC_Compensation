using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MVC.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace MVC.Controllers
{
    public class RequestController : BaseController<CompensationRequest, int>
    {
        public ViewResult Details() => View();

        public ViewResult Requester() => View();

        public ViewResult Approval() => View();

        [HttpPost]
        public override async Task<IActionResult> Post([FromBody] CompensationRequest compensationRequest)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
            compensationRequest.RequestDate = DateTime.Now;
            StringContent content = new StringContent(JsonConvert.SerializeObject(compensationRequest), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("CompensationRequest", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<CompensationRequest>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
