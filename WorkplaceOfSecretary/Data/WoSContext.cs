using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkplaceOfSecretary.Models;

namespace WorkplaceOfSecretary.Data
{
    public class WoSContext : DbContext
    {
        public WoSContext(DbContextOptions<WoSContext> options) : base(options)
        {
        }

        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
