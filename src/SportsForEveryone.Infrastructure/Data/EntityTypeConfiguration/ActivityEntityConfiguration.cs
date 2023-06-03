using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsForEveryone.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Infrastructure.Data.EntityTypeConfiguration
{
    public class ActivityEntityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasKey(c => c.ActivityId);
            builder.Property(c => c.Name)
                .IsRequired();
            builder.Property(c => c.Price) 
                .IsRequired();
            //builder.Property(c => c.Shedule)
            //    .IsRequired();

        }
    }
}
