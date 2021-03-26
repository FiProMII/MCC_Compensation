using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Position")]
    public class Position
    {
        [Key][Required]
        public int PositionID { get; set; }
        public string PositionName { get; set; }

        [Required]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        [JsonIgnore]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
