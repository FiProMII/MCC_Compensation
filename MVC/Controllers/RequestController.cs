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
    public class RequestController : BaseController<CompensationRequest, int>
    {
        public ViewResult Requester() => View();

        public ViewResult Approval() => View();
    }
}
