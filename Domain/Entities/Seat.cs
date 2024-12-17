using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Seat
    {
        [Key]
        public uint ID { get; set; }
        [Required]
        public uint Row { get; set; }
        [Required]
        public uint Number { get; set; }
        [Required]
        public uint RoomID { get; set; }

        public virtual Room? Room { get; set; }
        public virtual List<ReservedSeat>? ReservedSeats { get; set; }
    }
}
