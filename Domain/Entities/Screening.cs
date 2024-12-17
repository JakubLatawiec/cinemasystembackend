using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Screening
    {
        [Key]
        public uint ID { get; set; }
        [Required]
        public uint MovieID { get; set; }
        [Required]
        public uint RoomID { get; set; }
        [Required]
        public DateTime ScreeningDate { get; set; }

        public virtual Movie? Movie { get; set; }
        public virtual Room? Room { get; set; }
    }
}
