using Microsoft.EntityFrameworkCore;
using SportsForEveryone.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Core.Interfaces
{
    public interface IDataDbContext : IDisposable
    {
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        int SaveChanges();

    }
}
