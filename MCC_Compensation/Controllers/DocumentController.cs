using API.Base.Controller;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DocumentController : BaseController<Document, DocumentRepository, int>
    {

        private IWebHostEnvironment _hostingEnvironment;

        public DocumentController(DocumentRepository documentRepository, IWebHostEnvironment environment) : base(documentRepository)
        {
            _hostingEnvironment = environment;
        }

        [HttpPost("Upload")]
        public async Task<IActionResult> Upload(IEnumerable<IFormFile> Files)
        {
            //var nik = "117104";
            //var date = DateTime.Now.ToString("dd-MM-yy");
            //string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            //if (file.Length > 0)
            //{
            //    string filePath = Path.Combine(uploads, nik + "_" + date + "_" + file.FileName);
            //    using Stream fileStream = new FileStream(filePath, FileMode.Create);
            //    await file.CopyToAsync(fileStream);
            //    fileStream.Close();
            //}
            return Ok();
        }
    }
}
