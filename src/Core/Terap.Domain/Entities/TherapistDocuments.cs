using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terap.Domain.Entities
{
    public class TherapistDocuments
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("Document")]
        public Guid DocumentTypeID { get; set; }
        public string DocumentPath { get; set; }

        [ForeignKey("Therapist")]
        public Guid TherapistID { get; set; }
    }
}
