using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class PositionListVM
    {
        public int PositionID { get; set; }
        public string PositionName { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
