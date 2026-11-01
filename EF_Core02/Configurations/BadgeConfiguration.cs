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
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable(t => t.HasCheckConstraint("TierCheckConstrain", "tier IN (Standard,VIP)"));

            builder.HasKey(b => b.BadgeId);
            builder.Property(b=>b.BadgeId).HasDefaultValue(Guid.NewGuid().ToString()+DateTime.Now);

            builder.HasOne(b=> b.Attendee)
                    .WithOne(a => a.Badge)
                    .HasForeignKey<Badge>(b => b.AttendeeId);
        }
    }
}
