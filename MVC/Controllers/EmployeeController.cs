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
    public class EmployeeController : BaseController<Employee, string>
    {
        [HttpPost]
        public async Task<JsonResult> Validation(string Params)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(Params), Encoding.UTF8, "application/json");

            using var response = await httpClient.PostAsync("Employee/Validation/?Params=" + Params, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<Employee>>(apiResponse);
            return new JsonResult(result);
        }
    }
}
