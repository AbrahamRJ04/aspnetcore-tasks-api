using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApiProyect.DTOs;
using RestApiProyect.Models;
using System.Threading.Tasks;

namespace RestApiProyect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public TasksController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

      

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _context.Tareas.ToListAsync();
            return Ok(_mapper.Map<List<TaskDto>>(tasks));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var task = await _context.Tareas.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<TaskDto>(task));
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateTaskDto createTaskDto)
        {
            var task = _mapper.Map<Tareas>(createTaskDto);
            _context.Tareas.Add(task);
            await _context.SaveChangesAsync();
            var taskDto = _mapper.Map<TaskDto>(task);
            return CreatedAtAction(nameof(GetById), new { id = task.Id }, taskDto);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateTaskDto updateTaskDto)
        {

            var task = await _context.Tareas.FindAsync(id);
            if (task == null) return NotFound();

            _mapper.Map(updateTaskDto, task);

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
