using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Employee")]
    public class Employee
    {
        [Key][Required]
        public string NIK { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
       
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string BirthPlace { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [Required]
        public int PositionID {get;set;}

        public string ManagerNIK { get; set; }

        [JsonIgnore]
        public virtual Position Position { get; set; }

        [JsonIgnore]
        public virtual Employee Manager { get; set; }

        [JsonIgnore]
        public virtual Account Account { get; set; }

        [JsonIgnore]
        public virtual ICollection<CompensationRequest> CompensationRequests { get; set; }
    }
}
