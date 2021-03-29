using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class RequestStatusVM
    {
        public string StatusName { get; set; }
        public string Approval { get; set; }
        public DateTime ApprovalDate { get; set; }
    }
}
