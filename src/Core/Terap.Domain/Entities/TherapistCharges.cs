using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terap.Domain.Entities
{
    public class TherapistCharges
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("Duration")]
        public Guid DurationID { get; set; }
        public int Amount { get; set; }

        [ForeignKey("Therapist")]
        public Guid TherapistID { get; set; }
    }
}
