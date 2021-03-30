using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Department")]
    public class Department
    {
        [Key][Required]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<Approval> Approvals { get; set; }
    }
}
