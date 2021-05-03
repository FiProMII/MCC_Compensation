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

    public class PositionController : BaseController<Position, PositionRepository, int>
    {
        private readonly PositionRepository _positionRepository;
        public PositionController(PositionRepository positionRepository) : base(positionRepository)
        {
            _positionRepository = positionRepository;
        }

        [HttpGet("GetPosition")]
        public ActionResult<PositionListVM> GetPosition()
        {
            ResponseVM<IEnumerable<PositionListVM>> responseContent = new ResponseVM<IEnumerable<PositionListVM>>();
            var result = _positionRepository.GetList();

            if (result != null)
            {
                responseContent.Status = ResponseVM<IEnumerable<PositionListVM>>.StatusType.Success;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = ResponseVM<IEnumerable<PositionListVM>>.StatusType.Failed;
                responseContent.Message = "Something went wrong";
                return StatusCode(500, responseContent);
            }
        }
    }
}
