using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Models
{
    internal class Profile
    {

        public int ProfileId { get; set; }
        public string Biography { get; set; }

        public string WebsiteLink { get; set; }

        public string Logo { get; set; }

        #region Relationship

        // FK
        public int OrganizerId { get; set; }

        // Reference Navigation
        public Organizer Organizer { get; set; } = null!;
        #endregion
    }
}
