using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class RequestVM
    {
        public int RequestID { get; set; }
        public string ApplicantsName { get; set; }
        public DateTime JoinDate { get; set; }
        public string Manager { get; set; }
        public string CompensationName { get; set; }
        public string EventDate { get; set; }
        public string RequestDate { get; set; }
    }
}
