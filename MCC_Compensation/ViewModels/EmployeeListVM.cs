using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class EmployeeListVM
    {
        public string NIK { get; set; }

        public string EmployeeName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string BirthPlace { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime JoinDate { get; set; }
        public string PositionName { get; set; }
        public string DepartmentName { get; set; }
        public string Manager { get; set; }
    }
}
