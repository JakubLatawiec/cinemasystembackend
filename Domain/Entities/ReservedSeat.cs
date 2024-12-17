using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ReservedSeat
    {
        [Required]
        public uint SeatID { get; set; }
        [Required]
        public uint ReservationID { get; set; }
        [Required]
        public uint ScreeningID { get; set; }
        [Required]
        public uint TicketTypeID { get; set; }

        public virtual Seat? Seat { get; set; }
        public virtual Screening? Screening { get; set; }
        public virtual Reservation? Reservation { get; set; }
        public virtual List<TicketType>? TicketType { get; set; }
    }
}
