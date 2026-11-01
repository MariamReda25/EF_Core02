using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    internal class Badge
    {

        public string BadgeId { get; set; }

        public string tier { get; set; }

        #region Relationship
        public int AttendeeId { get; set; }

        public Attendee Attendee { get; set; }
        #endregion

    }
}
