using API.Repository.Interface;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.Base.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Entity, Repository, Key> : ControllerBase
        where Entity : class
        where Repository : IRepository<Entity, Key>
    {
        private readonly Repository repository;
        public BaseController(Repository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<Entity> Get()
        {
            ResponseVM<IEnumerable<Entity>> responseContent = new ResponseVM<IEnumerable<Entity>>();
            var result = repository.Get();

            if (result != null)
            {
                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.InternalServerError;
                responseContent.Message = "Something went wrong";
                return StatusCode(500, responseContent);
            }
        }

        [HttpGet("{key}")]
        public ActionResult<Entity> Get(Key key)
        {
            ResponseVM<Entity> responseContent = new ResponseVM<Entity>();

            if (key == null)
            {
                responseContent.Status = HttpStatusCode.BadRequest;
                responseContent.Message = "The request is incomplete or incorrect";
                return BadRequest(responseContent);
            }

            var result = repository.Get(key);

            if (result != null)
            {
                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Data found";
                responseContent.Result = result;
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.NotFound;
                responseContent.Message = "Something went wrong";
                return NotFound(responseContent);
            }
        }

        [HttpPost]
        public ActionResult Post(Entity entity)
        {
            ResponseVM<Entity> responseContent = new ResponseVM<Entity>();

            if (entity == null)
            {
                responseContent.Status = HttpStatusCode.BadRequest;
                responseContent.Message = "The data entered is incomplete or incorrect";
                return BadRequest(responseContent);
            }

            var result = repository.Insert(entity);

            if (result > 0)
            {
                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Data created successfully";
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.InternalServerError;
                responseContent.Message = "Unable to create new data";
                return StatusCode(500, responseContent);
            }
        }

        [HttpDelete("{key}")]
        public ActionResult Delete(Key key)
        {
            ResponseVM<Entity> responseContent = new ResponseVM<Entity>();

            if (key == null)
            {
                responseContent.Status = HttpStatusCode.BadRequest;
                responseContent.Message = "The request is incomplete or incorrect";
                return BadRequest(responseContent);
            }

            var result = repository.Delete(key);

            if (result > 0)
            {
                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Data deleted successfully";
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.InternalServerError;
                responseContent.Message = "Unable to delete data";
                return StatusCode(500, responseContent);
            }
        }

        [HttpPut]
        public ActionResult Put(Entity entity)
        {
            ResponseVM<Entity> responseContent = new ResponseVM<Entity>();

            if (entity == null)
            {
                responseContent.Status = HttpStatusCode.BadRequest;
                responseContent.Message = "The data entered is incomplete or incorrect";
                return BadRequest(responseContent);
            }

            var result = repository.Update(entity);

            if (result > 0)
            {
                responseContent.Status = HttpStatusCode.OK;
                responseContent.Message = "Data updated successfully";
                return Ok(responseContent);
            }
            else
            {
                responseContent.Status = HttpStatusCode.InternalServerError;
                responseContent.Message = "Unable to update data";
                return StatusCode(500, responseContent);
            }
        }
    }
}
