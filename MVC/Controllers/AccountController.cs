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

namespace MVC.Controllers
{
    public class AccountController : BaseController<Account, string>
    {
        [HttpPost]
        [Route("~/Account/SigninAction")]
        public async Task<JsonResult> Signin(LoginVM loginVM)
        {

            StringContent content = new StringContent(JsonConvert.SerializeObject(loginVM), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("Account/Login", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<string>>(apiResponse);
            HttpContext.Session.SetString("Token", result.Result);
            return Json(result);
        }

        public ViewResult ForgotPassword() => View();

        public ViewResult ChangePassword() => View();
    }
}
