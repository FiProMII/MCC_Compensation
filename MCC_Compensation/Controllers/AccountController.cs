﻿using API.Base.Controller;
using API.Models;
using API.Repositories.Data;
using API.Services;
using API.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController<Account, AccountRepository, string>
    {
        private readonly AccountRepository _accountRepository;
        private readonly IConfiguration _configuration;
        public AccountController(AccountRepository accountRepository, IConfiguration configuration) : base(accountRepository)
        {
            _accountRepository = accountRepository;
            _configuration = configuration;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginVM login)
        {
            var result = _accountRepository.Login(login);
            ResponseVM<string> responseContent = new ResponseVM<string>();
            if (result != null)
            {
                var jwt = new JwtServices(_configuration);
                var token = jwt.GenerateSecurityToken(result);

                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Sign In successful";
                responseContent.Result = token;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.Unauthorized;
                responseContent.Message = "Sign in failed";
                return BadRequest(responseContent);
            }
        }
    }
}
