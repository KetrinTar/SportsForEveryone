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
    public class ClubEntityConfiguration : IEntityTypeConfiguration<Club>
    {
        public void Configure(EntityTypeBuilder<Club> builder)
        {
            builder.HasKey(builder => builder.ClubId);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(30);
            builder.HasOne(c => c.Administrators)
                .WithOne(b => b.Club)
                .HasForeignKey<Administrator>(d => d.ClubId);
            builder.HasMany(c => c.Trainers)
                .WithOne(c => c.Club)
                .OnDelete(DeleteBehavior.NoAction);            
            builder.HasMany(c => c.Reviews)
                .WithOne(c => c.Club)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(c => c.Posts)
                .WithOne(c => c.Club)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
