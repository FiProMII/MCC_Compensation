using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class DetailRequestVM
    {
        public int RequestID { get; set; }
        public string EmployeeName { get; set; }
        public string PositionName { get; set; }
        public string DepartmentName { get; set; }
        public DateTime JoinDate { get; set; }
        public string Manager { get; set; }
        public string CompensationName { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime RequestDate { get; set; }
        public string Note { get; set; }
    }
}
