using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Room
    {
        [Key]
        public uint ID { get; set; }
        [Required]
        [MaxLength(254)]
        public string Name { get; set; } = string.Empty;

        public virtual List<Screening>? Screenings { get; set; }
        public virtual List<Seat>? Seats { get; set; }
    }
}
