using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terap.Domain.Entities
{
    public class SubscriptionFeature
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("SubscriptionType")]
        public Guid SubscriptionTypeID { get; set; }

        [ForeignKey("Features")]
        public Guid FeatureID { get; set; }
    }
}
