using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terap.Domain.Entities
{
    public class State
    {
        [Key]
        public Guid ID { get; set; }

        
        public string Name { get; set; }

        [ForeignKey("Country")]
        public Guid CountryId { get; set; }
        public Country Country { get; set; }

    }
}
