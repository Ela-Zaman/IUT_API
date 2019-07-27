using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    public class AddDBContext:DbContext
    {
        public DbSet<FacultyMember> FacultyMember { get; set; }
         public DbSet<Student> student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseNpgsql("Host=localhost;Database=IUTAPI;Username=CodeBlue;Password=iutswe");
    }
}
