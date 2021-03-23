using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MVC.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.IO;

namespace MVC.Controllers
{
    public class DocumentController : BaseController<DocumentVM, int>
    {

        [HttpPost]
        public override async Task<IActionResult> Post(DocumentVM documentVM)
        {
            var files = documentVM.File;
            var content = new MultipartFormDataContent();

            foreach (var file in files)
            {
                if (file.Length <= 0)
                    continue;

                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                content.Add(new StreamContent(file.OpenReadStream())
                {
                    Headers =
                    {
                        ContentLength = file.Length,
                        ContentType = new MediaTypeHeaderValue(file.ContentType)
                    }
                }, "Files", fileName);
            }

            var response = await httpClient.PostAsync("Document/Upload", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<CompensationRequest>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
