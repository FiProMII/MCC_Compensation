using API.Repositories.Interface;
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
            var result = repository.Get();

            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result, message = "Data found" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, result, message = "Something went wrong" }); ;
            }
        }

        [HttpGet("{key}")]
        public ActionResult<Entity> Get(Key key)
        {
            var result = repository.Get(key);
            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result, message = "Data found" });
            }
            else
            {
                return NotFound(new { status = HttpStatusCode.NotFound, message = "Data not found" });
            }
        }

        [HttpPost]
        public ActionResult Post(Entity entity)
        {
            var result = repository.Insert(entity);
            if (result > 0)
            {
                return Ok(new { status = HttpStatusCode.OK, result = "", message = "Successfully created new data" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, message = "Unable to create new data" });
            }
        }

        [HttpDelete("{key}")]
        public ActionResult Delete(Key key)
        {
            var result = repository.Delete(key);
            if (result > 0)
            {
                return Ok(new { status = HttpStatusCode.OK, result = "", message = "Successfully deleted data" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, message = "Could not successfully delete data" });
            }
        }

        [HttpPut]
        public ActionResult Put(Entity entity)
        {
            if (entity == null)
            {
                return BadRequest(new { status = HttpStatusCode.BadRequest, message = "The data entered is incomplete or incorrect" });
            }

            var result = repository.Update(entity);

            if (result > 0)
            {
                return Ok(new { status = HttpStatusCode.OK, result = "", message = "Data updated successfully" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, message = "Data not updated successfully" });
            }
        }
    }
}
