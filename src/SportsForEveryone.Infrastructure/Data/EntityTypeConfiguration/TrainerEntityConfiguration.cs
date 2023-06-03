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
    public class TrainerEntityConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasKey(c => c.TrainerId);
            builder.Property(c => c.Name)
                .IsRequired();
            builder.HasMany(c => c.Reviews)
                .WithOne(c => c.Trainer)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(c => c.Activities)
                .WithOne(c => c.Trainer)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
