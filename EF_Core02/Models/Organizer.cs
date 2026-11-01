using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    internal class Organizer
    {
        [Key]
        public int OraginzerId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        public string ?VerifiedSatuts { get; set; }

        public Profile? Profile { get; set; }
    }
}
