using API.Base.Controller;
using API.Models;
using API.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AccountController : BaseController<Account, AccountRepository, string>
    {
        public AccountController(AccountRepository accountRepository) : base(accountRepository)
        {

        }
    }
}
