using EF_Core02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Configurations
{
    internal class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            // Composite Key "Profile weak Entity"
            builder.HasKey(p => new { p.ProfileId, p.OrganizerId });

            builder.HasOne(p => p.Organizer)
                    .WithOne(o => o.Profile)
                    .HasForeignKey<Profile>(p => p.OrganizerId);
        }
    }
}
