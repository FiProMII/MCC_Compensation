using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class DocumentVM
    {
        public string NIK { get; set; }
        public string DocumentName { get; set; }
        public IEnumerable<IFormFile> File { get; set; }
    }
}
