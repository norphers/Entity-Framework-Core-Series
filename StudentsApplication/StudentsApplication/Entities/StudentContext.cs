using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsApplication.Entities
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .ToTable("Student");
            modelBuilder.Entity<Student>()
                .HasKey(s => new { s.Id, s.AnotherKeyProperty });
            modelBuilder.Entity<Student>()
                .Property(s => s.Id)
                .HasColumnName("StudentId");
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Student>()
                .Property(s => s.Age)
                .IsRequired(false);
        }

        public DbSet<Student> Students { get; set;}
    }
}
