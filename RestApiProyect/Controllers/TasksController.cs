using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApiProyect.Models;
using System.Threading.Tasks;

namespace RestApiProyect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private readonly AppDbContext _context;

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _context.Tareas.ToListAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var task = await _context.Tareas.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tareas task)
        {
            _context.Tareas.Add(task);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Tareas updateTask)
        {
            var task = await _context.Tareas.FindAsync(id);
            if (task == null) return NotFound();

            task.Titulo = updateTask.Titulo;
            task.Descripcion = updateTask.Descripcion;
            task.Estatus = updateTask.Estatus;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.Tareas.FindAsync(id);
            if (task == null) return NotFound();

            _context.Tareas.Remove(task);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
