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

        [HttpPost("Upload")]
        public async Task<IActionResult> Upload(IEnumerable<IFormFile> Files)
        {
            ResponseVM<Document> responseContent = new ResponseVM<Document>();
            string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            List<Document> documents = new List<Document>();
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

                    documents.Add(document);
                }
            }

            return Ok(documents);
        }
    }
}