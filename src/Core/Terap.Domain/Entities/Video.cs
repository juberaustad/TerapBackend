using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terap.Domain.Entities
{
    public class Video
    {

        [Key]
        public Guid ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Path { get; set; }

        [ForeignKey("Therapist")]
        public Guid TherapistId { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public Therapist Therapist { get; set; }

        public Category Category { get; set; }
    }
}
