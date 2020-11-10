using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities;

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
            //logic with the injected _context object.
            var entity = _context.Model
                .FindEntityType(typeof(Student).FullName);

            var tableName = entity.GetTableName();
            var schemaName = entity.GetSchema();
            var key = entity.FindPrimaryKey();
            var properties = entity.GetProperties();

            return Ok();
        }
    }
}
