﻿using API.Base.Controller;
using API.Models;
using API.Repository.Data;
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

    public class CompensationController : BaseController<Compensation, CompensationRepository, int>
    {
        public CompensationController(CompensationRepository compensationRepository) : base(compensationRepository)
        {

        }
    }
}
