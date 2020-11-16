using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities;
using System.Linq;
using System.Collections.Generic;

namespace StudentsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly StudentContext _context;

        public ValuesController(StudentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //1-UNDERSTANDING QUERIES

            //first part where we access the Student table in the database via the DbSet<Student> Students property 
            //var students = _context.Students
            //    .AsNoTracking() 
            //   second part of the query where we use a LINQ command to select only required rows
            //   .Where(s => s.Age > 25)
            //   third part executes this query
            //   .ToList();


            //2-RELATIONAL QUERIES WITH EAGER LOADING

            //var students = _context.Students
            //    .Include(e => e.Evaluations)
            //    .Include(ss => ss.StudentSubjects)
            //    .ThenInclude(s => s.Subject)
            //    .FirstOrDefault();


            //3-RELATIONAL QUERIES WITH EXPLICIT LOADING

            //3.1 - WITH Load()

            //var student = _context.Students.FirstOrDefault();
            //_context.Entry(student)
            //    .Collection(e => e.Evaluations)
            //    .Load();

            //_context.Entry(student)
            //    .Collection(ss => ss.StudentSubjects)
            //    .Load();

            //foreach (var studentSubject in student.StudentSubjects)
            //{
            //    _context.Entry(studentSubject)
            //        .Reference(s => s.Subject)
            //        .Load();
            //}

            //3.2 - WITH Query()

            //var student = _context.Students.FirstOrDefault();

            //var evaluationsCount = _context.Entry(student)
            //    .Collection(e => e.Evaluations)
            //    .Query()
            //    .Count();

            //var gradesPerStudent = _context.Entry(student)
            //    .Collection(e => e.Evaluations)
            //    .Query()
            //    .Select(e => e.Grade)
            //    .ToList();


            //4-RELATIONAL QUERIES WITH SELECT (PROJECTION) LOADING

            //var student = _context.Students
            //    .Select(s => new
            //    {
            //        s.Name,
            //        s.Age,
            //        NumberOfEvaluations = s.Evaluations.Count
            //    })
            //    .ToList();


            //5-CLIENT VS SERVER EVALUATION

            //var student = _context.Students
            //    .Where(s => s.Name.Equals("John Doe"))
            //    .Select(s => new
            //    {
            //        s.Name,
            //        s.Age,
            //        Explanations = string.Join(",", s.Evaluations
            //            .Select(e => e.AdditionalExplanation))
            //    })
            //    .FirstOrDefault();

            //6-RAW SQL COMMANDS

            //6.1-FromSqlRaw Method
            //var student = _context.Students
            //    .FromSqlRaw(@"SELECT * FROM Student WHERE Name = {0}", "John Doe")
            //    .FirstOrDefault();

            //we can also call stored procedures from a database
            //var student = _context.Students
            //    .FromSqlRaw("EXECUTE dbo.MyCustomProcedure")
            //    .ToList();

            //if we want to include relationships to our query
            //var student = _context.Students
            //    .FromSqlRaw("SELECT * FROM Student WHERE Name = {0}", "John Doe")
            //    .Include(e => e.Evaluations)
            //    .FirstOrDefault();
            //return OK(student);

            //6.2-ExecuteSqlRaw Method
            //var rowsAffected = _context.Database
            //    .ExecuteSqlRaw(
            //        @"UPDATE Student
            //          SET Age = {0} 
            //          WHERE Name = {1}", 29, "Mike Miles");
            
            //return Ok(new { RowsAffected = rowsAffected });

            //6.3-Reloaded Method
            var studentForUpdate = _context.Students
                .FirstOrDefault(s => s.Name.Equals("Mike Miles"));
            var age = 28;
            var rowsAffected = _context.Database
                .ExecuteSqlRaw(@"UPDATE Student 
                       SET Age = {0} 
                       WHERE Name = {1}", age, studentForUpdate.Name);
            //What if we want it to change after the execution of the ExecuteSqlRaw method? We use the next code row.
            _context.Entry(studentForUpdate).Reload();

            return Ok(new { RowsAffected = rowsAffected });
        }

        [HttpPost] //create rows - using '.Add()' method
        public IActionResult Post([FromBody] Student student)
        {
            if (student == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();
            _context.Add(student);
            _context.SaveChanges();
            return Created("URI of the created entity", student);
        }

        [HttpPost("postrange")] //create rows - using '.AddRange()' method
        public IActionResult PostRange([FromBody] IEnumerable<Student> students)
        {
            //additional checks
            _context.AddRange(students);
            _context.SaveChanges();
            return Created("URI is going here", students);
        }
    }
}
