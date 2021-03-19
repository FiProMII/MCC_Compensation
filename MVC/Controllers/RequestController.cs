using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MVC.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class RequestController : BaseController<CompensationRequest, int>
    {
        [HttpGet]
        [Route("Request/GetRequest")]
        public async Task<JsonResult> CompensationRequest()
        {
            using var response = await httpClient.GetAsync("CompensationRequest/Request");
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<IEnumerable<RequestVM>>>(apiResponse);
            return new JsonResult(result);
        }
    }
}
