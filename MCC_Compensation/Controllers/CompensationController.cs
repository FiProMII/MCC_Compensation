using API.Base.Controller;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
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
        private readonly CompensationRepository _compensationRepository;
        public CompensationController(CompensationRepository compensationRepository) : base(compensationRepository)
        {
            _compensationRepository = compensationRepository;
        }

        [HttpGet]
        public override ActionResult<Compensation> Get()
        {
            ResponseVM<IEnumerable<Compensation>> responseContent = new ResponseVM<IEnumerable<Compensation>>();
            var result = _compensationRepository.GetList();

            if (result != null)
            {
                responseContent.Status = ResponseVM<IEnumerable<Compensation>>.StatusType.Success;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<IEnumerable<Compensation>>.StatusType.Failed;
                responseContent.Message = "Something went wrong";
                return StatusCode(500, responseContent);
            }
        }
    }
}
