using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class RequestListVM
    {
        public int RequestID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime JoinDate { get; set; }
        public string Manager { get; set; }
        public string CompensationName { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
