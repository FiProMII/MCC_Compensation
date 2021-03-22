using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class ApprovalController : BaseController<Approval, int>
    {
        [HttpPost]
        public override async Task<IActionResult> Post([FromBody]Approval approval)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
            approval.ApprovalDate = DateTime.Now;
            StringContent content = new StringContent(JsonConvert.SerializeObject(approval), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("Approval", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<Approval>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
