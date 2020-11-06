using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Student")] //override the name of DbSet<T> in the StudentContext class
    public class Student
    {
        [Column("StudentId")]
        public Guid Id { get; set; }
        //public Guid AnotherKeyProperty { get; set; }
        [Required] //field 'Name' can't be nullable
        [MaxLength(12, ErrorMessage = "Length must be less than 12 characters")] //limiting the length of that column in the database
        public string Name { get; set; }       
        public int? Age { get; set; }
        public bool IsRegularStudent { get; set; }

        //One-to-One relationship
        public StudentDetails StudentDetails { get; set; }
    }
}
