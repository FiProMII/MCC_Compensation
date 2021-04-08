using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_Approval")]
    public class Approval
    {
        [Key][Required]
        public int ApprovalID { get; set; }
        public int StatusID { get; set; }
        public string NIK { get; set; }
        public int RequestID { get; set; }
        public int DepartmentID { get; set; }

        [DataType(DataType.Date)]
        public DateTime ApprovalDate { get; set; }
        public string Note { get; set; }
        public virtual Status Status { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Department Department { get; set; }
        public virtual CompensationRequest CompensationRequest { get; set; }
    }
}
