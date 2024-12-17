using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ReservationHistory
    {
        [Key]
        public uint ID { get; set; }
        [Required]
        public uint UserID { get; set; }
        [Required]
        public string MovieName { get; set; } = string.Empty;
        [Required]
        public string RoomName { get; set; } = string.Empty;
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public bool Paid { get; set; }
        
        public virtual List<ReservedSeatHistory>? ReservedSeatsHistory { get; set;}
    }
}
