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
    public class AdministratorEntityConfiguration : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            builder.HasKey(c => c.AdministratorId);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(c => c.Phone)
                .IsRequired();
            builder.Property(c => c.Email)
                .IsRequired();
        }
    }
}
