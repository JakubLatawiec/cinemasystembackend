using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public uint ID { get; set; }
        [Required]
        [MaxLength(254)]
        public string Title { get; set; } = string.Empty;
        [AllowNull]
        [MaxLength(255)]
        public string? Director { get; set; }
        [Required]
        public DateTime LicenseSince { get; set; }
        [Required]
        public DateTime LicenseUntil { get; set; }
        [Required]
        public uint Length { get; set; }

        public virtual List<Screening>? Screenings { get; set; }
    }
}
