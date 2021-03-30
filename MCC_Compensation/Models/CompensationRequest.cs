using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_CompensationRequest")]
    public class CompensationRequest
    {
        [Key]
        [Required]
        public int RequestID { get; set; }

        public string NIK { get; set; }

        public int CompensationID { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Compensation Compensation { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Approval> Approvals { get; set; }
    }
}
