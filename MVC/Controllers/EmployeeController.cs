﻿using API.Models;
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
    public class EmployeeController : BaseController<Employee, string>
    {
        [HttpPost]
        public async Task<JsonResult> Validation(string Params)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
            StringContent content = new StringContent(JsonConvert.SerializeObject(Params), Encoding.UTF8, "application/json");
            using var response = await httpClient.PostAsync("Employee/Validation/?Params=" + Params, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<Employee>>(apiResponse);
            return new JsonResult(result);
        }

        [HttpPost]
        public override async Task<IActionResult> Post(Employee employee)
        {
            if (employee.ManagerNIK == "-1")
            {
                employee.ManagerNIK = null;
            }

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
            StringContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("Employee", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<Employee>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
            var response = await httpClient.GetAsync("Employee/GetEmployees");
            var apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<IEnumerable<EmployeeListVM>>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetManagerList()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
            var response = await httpClient.GetAsync("Employee/GetManagerList");
            var apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<IEnumerable<ManagerVM>>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
