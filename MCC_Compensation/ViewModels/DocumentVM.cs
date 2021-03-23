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
        public IEnumerable<IFormFile> File { get; set; }
        public int RequestID { get; set; }
    }
}
