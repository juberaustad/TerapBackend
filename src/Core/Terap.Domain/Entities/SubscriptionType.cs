﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terap.Domain.Entities
{
    public class SubscriptionType
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Duration")]
        public Guid DurationID { get; set; }
        public int Amount { get; set; }
    }
}
