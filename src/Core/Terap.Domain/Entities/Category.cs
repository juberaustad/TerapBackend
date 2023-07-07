using Terap.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Terap.Domain.Entities;

namespace Terap.Domain.Entities
{
    public class Category : AuditableEntity
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }




    }
}
