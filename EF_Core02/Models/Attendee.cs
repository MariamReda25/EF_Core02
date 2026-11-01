using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    internal class Attendee
    {
        public int AttendeeId { get; set; }

        [MaxLength(150)]
        public string? FullName { get; set; }
        [MaxLength(200)]
        public string? Email { get; set; }

        [MaxLength(150)]
        public string? Street { get; set; }

        [MaxLength(100)]
        public string? City { get; set; }
        [MaxLength(100)]
        public string? Country { get; set; }

        [MaxLength(20)]
        public string? ZipCode { get; set; }

        [NotMapped]
        public string FullAddress { get
            {
                return $"{Street}, {City}, {Country}, {ZipCode}";
            } }

        #region Relationship
        public Badge? Badge { get; set; }
        #endregion
    }
}
