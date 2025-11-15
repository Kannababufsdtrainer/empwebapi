using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly Models.EmpDbContext _context;
        public EmpController(Models.EmpDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
           var employees=_context.Employees.ToList();
            return Ok(employees);
        }
    }
}
