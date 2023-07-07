using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terap.Domain.Entities
{
    public class TherapistBankDetails
    {
        [Key]
        public Guid ID { get; set; }
        public string AccountName { get; set; }

        [ForeignKey("Bank")]
        public Guid BankID { get; set; }
        public string Branch { get; set; }
        public string AccountNumber { get; set; }
        public string IFSC { get; set; }
        public string MICR { get; set; }

        [ForeignKey("Therapist")]
        public Guid TherapistID { get; set; }
        
    }
}
