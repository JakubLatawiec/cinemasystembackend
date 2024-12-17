using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Reservation
    {
        [Key]
        public uint ID { get; set; }
        [Required]
        public uint UserID { get; set; }
        [Required]
        public bool Paid { get; set; }
        [Required]
        public bool Active { get; set; }

        public virtual List<ReservedSeat>? ReservedSeats { get; set; }
        public virtual User? User { get; set; }
    }
}
