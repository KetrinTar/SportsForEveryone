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
    public class ReviewEntityConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(c => c.ReviewId);
            builder.Property(c => c.Summary)
                .IsRequired();
            builder.Property(c => c.Rate)
                .IsRequired();
            builder.ToTable("Reviews");
        }
    }
}
