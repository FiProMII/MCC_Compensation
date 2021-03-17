using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Document")]
    public class Document
    {
        [Key][Required]
        public int DocumentID { get; set; }
        public string DocumentName { get; set; }
        public string Link { get; set; }

        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }

        [Required]
        public int RequestID { get; set; }

        [JsonIgnore]
        public virtual CompensationRequest CompensationRequest { get; set; }
    }
}
