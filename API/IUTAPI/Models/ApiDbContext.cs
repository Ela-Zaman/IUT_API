﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IUTAPI.Models
{
    public class ApiDbContext : DbContext
    {
        private readonly string conenctionString;

        public ApiDbContext(IConfiguration configuration)
        {
            conenctionString = configuration.GetConnectionString("API");
        }

        public DbSet<FacultyMember> FacultyMember { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<CourseAssigned> CourseAssigned { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<DepartmentalCourse> DepartmentalCourse { get; set; }
        public DbSet<ApiKey> ApiKey { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(conenctionString);
        }
    }
}
