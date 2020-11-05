using Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            
            //the code below is now in the 'StudentConfiguration' class//
            
            /*
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
            modelBuilder.Entity<Student>()
                .Property(s => s.IsRegularStudent)
                .HasDefaultValue(true);

            modelBuilder.Entity<Student>()
                .HasData(
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "John Doe",
                        Age = 30
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Jane Doe",
                        Age = 25
                    }
                );
            */
        }

        public DbSet<Student> Students { get; set;}
    }
}
