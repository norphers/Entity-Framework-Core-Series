using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities;
using System.Linq;

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
            /* STEP 1
            //first part where we access the Student table in the database via the DbSet<Student> Students property
            var students = _context.Students
                .AsNoTracking() 
               //second part of the query where we use a LINQ command to select only required rows
               .Where(s => s.Age > 25)
               //third part executes this query
               .ToList();
            */

            var students = _context.Students
                .Include(e => e.Evaluations)
                .FirstOrDefault();
            
            return Ok(students);
        }
    }
}
