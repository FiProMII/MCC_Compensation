﻿using API.Base.Controller;
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

    public class EmployeeController : BaseController<Employee, EmployeeRepository, string>
    {
        public EmployeeController(EmployeeRepository employeeRepository) : base(employeeRepository)
        {

        }
    }
}
