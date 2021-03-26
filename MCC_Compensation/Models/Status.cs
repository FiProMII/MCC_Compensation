using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Status")]
    public class Status
    {
        [Key][Required]
        public int StatusID { get; set; }
        public string StatusName { get; set; }

        [JsonIgnore]
        public virtual ICollection<Approval> Approvals { get; set; }
    }
}
