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
        [DataType(DataType.Date)]
        public DateTime ApprovalDate { get; set; }
        [JsonIgnore]
        public virtual Status Status { get; set; }
        [JsonIgnore]
        public virtual Employee Employee { get; set; }
        [JsonIgnore]
        public virtual CompensationRequest CompensationRequest { get; set; }
    }
}
