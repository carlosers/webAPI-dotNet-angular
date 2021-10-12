using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController()
        {
            
        }
        [HttpGet] //decorator
        public IActionResult Get()
        {
            return Ok("Professores: Celso Hilda Alessandra Ingrid");
        }

    }
}