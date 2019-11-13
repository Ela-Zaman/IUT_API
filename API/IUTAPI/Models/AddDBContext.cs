﻿using Microsoft.EntityFrameworkCore;
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

        public DbSet<Course> Course { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<CourseAssigned> CourseAssigned { get; set; }
        
        public DbSet<Department> Department { get; set; }
        public DbSet<DepartmentalCourse> DepartmentalCourse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseNpgsql("Host=localhost;Database=IUTAPI;Username=CodeBlue;Password=iutswe");
    }
}
