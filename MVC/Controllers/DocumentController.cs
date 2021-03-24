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
            
            var date = DateTime.Now.ToString("dd-MM-yy");
            var nik = documentVM.NIK;

            foreach (var file in files)
            {
                if (file.Length <= 0)
                    continue;

                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                fileName = nik + "_" + date + "_" + fileName;

                content.Add(new StreamContent(file.OpenReadStream())
                {
                    Headers =
                    {
                        ContentLength = file.Length,
                        ContentType = new MediaTypeHeaderValue(file.ContentType)
                    }
                }, "Files", fileName);
            }

            var documentResponse = await httpClient.PostAsync("Document/Upload", content);
            string documentApiResponse = await documentResponse.Content.ReadAsStringAsync();
            var Documents = JsonConvert.DeserializeObject<List<Document>>(documentApiResponse);

            CompensationRequest compensationRequest = new CompensationRequest();
            compensationRequest.NIK = nik;
            compensationRequest.CompensationID = documentVM.CompensationID;
            compensationRequest.EventDate = documentVM.EventDate;
            compensationRequest.RequestDate = DateTime.Now;
            compensationRequest.Documents = Documents;

            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(compensationRequest), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("CompensationRequest", stringContent);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseVM<CompensationRequest>>(apiResponse);
            if (response.IsSuccessStatusCode)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
