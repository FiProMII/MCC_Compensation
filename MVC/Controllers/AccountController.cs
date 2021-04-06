﻿using API.Models;
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
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Net.Http.Headers;

namespace MVC.Controllers
{
    public class AccountController : BaseController<Account, string>
    {
        [HttpPost]
        public async Task<IActionResult> Signin(LoginVM loginVM)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginVM), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("Account/Login", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<string>>(apiResponse);

            if (response.IsSuccessStatusCode)
            {
                HttpContext.Session.SetString("Token", result.Result);
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        public ViewResult ForgotPassword() => View();

        [HttpPost]
        public async Task<IActionResult> ForgotPassword([FromBody] LoginVM loginVM)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginVM), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("Account/ForgotPassword", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<string>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }

        public ViewResult ChangePassword() => View();

        public override async Task<IActionResult> Put(Account account)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
            account.NIK = User.FindFirstValue("NIK");
            StringContent content = new StringContent(JsonConvert.SerializeObject(account), Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("Account", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<string>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }

        public ViewResult Profil() => View(); 

        public ViewResult AccountSetting() => View();

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Ok();
        }
    }
}
