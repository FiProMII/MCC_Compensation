﻿using API.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class AccountRoleController : BaseController<AccountRole, (string, int)>
    {
    }
}