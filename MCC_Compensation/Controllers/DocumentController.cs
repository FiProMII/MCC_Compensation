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
using System.Net;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DocumentController : BaseController<Document, DocumentRepository, int>
    {

        private IWebHostEnvironment _hostingEnvironment;
        private readonly DocumentRepository _documentRepository;

        public DocumentController(DocumentRepository documentRepository, IWebHostEnvironment environment) : base(documentRepository)
        {
            _hostingEnvironment = environment;
            _documentRepository = documentRepository;
        }

        [HttpPost("Upload/{key}")]
        public async Task<IActionResult> Upload(IEnumerable<IFormFile> Files, int key)
        {
            ResponseVM<Document> responseContent = new ResponseVM<Document>();
            string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            var isSuccess = true;
            foreach (var file in Files)
            {
                if (file.Length > 0)
                {
                    string filePath = Path.Combine(uploads, file.FileName);
                    using Stream fileStream = new FileStream(filePath, FileMode.Create);
                    await file.CopyToAsync(fileStream);
                    fileStream.Close();

                    Document document = new Document();
                    document.DocumentName = file.FileName;
                    document.Link = filePath;
                    document.RequestID = key;

                    var result = _documentRepository.Insert(document);

                    if (result <= 0)
                    {
                        isSuccess = false;
                        break;
                    }
                }
            }

            if (isSuccess)
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
    }
}