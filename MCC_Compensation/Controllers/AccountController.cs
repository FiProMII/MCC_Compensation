using API.Base.Controller;
using API.Models;
using API.Repository.Data;
using API.Services;
using API.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController<Account, AccountRepository, string>
    {
        private readonly AccountRepository _accountRepository;
        private readonly IConfiguration _configuration;
        private IWebHostEnvironment _hostingEnvironment;

        public AccountController(AccountRepository accountRepository, IConfiguration configuration, IWebHostEnvironment hostingEnvironment) : base(accountRepository)
        {
            _accountRepository = accountRepository;
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public IActionResult Login(LoginVM login)
        {
            var result = _accountRepository.Login(login);
            ResponseVM<string> responseContent = new ResponseVM<string>();
            if (result != null)
            {
                var jwt = new JwtServices(_configuration);
                var token = jwt.GenerateSecurityToken(result);

                if (result.IsTemp)
                {
                    responseContent.Status = ResponseVM<string>.StatusType.Warning;
                    responseContent.Message = "You need to change your password";
                    responseContent.Result = token;
                } 
                else
                {
                    responseContent.Status = ResponseVM<string>.StatusType.Success;
                    responseContent.Message = "Sign in successful";
                    responseContent.Result = token;
                }
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<string>.StatusType.Failed;
                responseContent.Message = "Sign in failed";
                return BadRequest(responseContent);
            }
        }

        [HttpPut]
        public override ActionResult Put(Account account)
        {
            ResponseVM<Account> responseContent = new ResponseVM<Account>();

            if (account == null)
            {
                responseContent.Status = ResponseVM<Account>.StatusType.Failed;
                responseContent.Message = "The data entered is incomplete or incorrect";
                return BadRequest(responseContent);
            }

            account.Password = BC.EnhancedHashPassword(account.Password);
            var result = _accountRepository.Update(account);

            if (result > 0)
            {
                responseContent.Status = ResponseVM<Account>.StatusType.Success;
                responseContent.Message = "Data updated successfully";
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<Account>.StatusType.Failed;
                responseContent.Message = "Unable to update data";
                return StatusCode(500, responseContent);
            }
        }

        [HttpPost("ForgotPassword")]
        [AllowAnonymous]
        public IActionResult ForgotPassword(LoginVM loginVM)
        {
            var result = _accountRepository.ForgotPassword(loginVM.Email);
            ResponseVM<string> responseContent = new ResponseVM<string>();
            if (result != null)
            {
                EmailController emailController = new EmailController(_hostingEnvironment);
                emailController.SendEmail(loginVM.Email, EmailController.EmailType.TemporaryPassword, result);

                responseContent.Status = ResponseVM<string>.StatusType.Success;
                responseContent.Message = "New password sent";
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<string>.StatusType.Failed;
                responseContent.Message = "Email is not found";
                return NotFound(responseContent);
            }
        }
    }
}
