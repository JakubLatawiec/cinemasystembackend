﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TicketType
    {
        [Key]
        public uint ID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public float Price { get; set; }

        public virtual ReservedSeat? ReservedSeat { get; set; }
    }
}
