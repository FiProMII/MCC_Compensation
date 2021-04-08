using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class UpdateStatusVM
    {
        public int RequestID { get; set; }
        public int DepartmentID { get; set; }
        public string StatusName { get; set; }
        public string NIK { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string Note { get; set; }
    }
}
