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
        public int CompensationID { get; set; }
        public DateTime EventDate { get; set; }
        public int RequestID { get; set; }
        public IEnumerable<IFormFile> File { get; set; }
    }
}
