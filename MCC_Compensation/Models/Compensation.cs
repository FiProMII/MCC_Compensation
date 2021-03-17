using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Compensation")]
    public class Compensation
    {
        [Key][Required]
        public int CompensationID { get; set; }
        public string CompensationName { get; set; }
        public int Cost { get; set; }

        [JsonIgnore]
        public virtual ICollection<CompensationRequest> CompensationRequests { get; set; }
    }
}
