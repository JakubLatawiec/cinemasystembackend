using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ReservedSeatHistory
    {
        [Key]
        public uint ID { get; set; }
        [Required]
        public uint ReservationHistoryID { get; set; }
        [Required]
        public uint SeatID { get; set; }
        [Required]
        public uint SeatNumber { get; set; }
        [Required]
        public uint SeatRow { get; set; }
        [Required]
        public string TicketType { get; set; } = string.Empty;
        [Required]
        public float Price { get; set; }
    }
}
