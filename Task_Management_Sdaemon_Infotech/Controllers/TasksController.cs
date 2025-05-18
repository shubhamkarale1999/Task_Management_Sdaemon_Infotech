using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_Management_Sdaemon_Infotech.Data;
using Task_Management_Sdaemon_Infotech.Model;

namespace Task_Management_Sdaemon_Infotech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly TaskManagementContext _context;

        public TasksController(TaskManagementContext context)
        {
            _context = context;
        }

        // GET: api/Tasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskManagement>>> GetTaskManagement()
        {
            return await _context.TaskManagement.ToListAsync();
        }

        // GET: api/Tasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskManagement>> GetTaskManagement(int id)
        {
            var taskManagement = await _context.TaskManagement.FindAsync(id);

            if (taskManagement == null)
            {
                return NotFound();
            }

            return taskManagement;
        }

        // PUT: api/Tasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskManagement(int id, TaskManagement taskManagement)
        {
            if (id != taskManagement.Id)
            {
                return BadRequest();
            }

            _context.Entry(taskManagement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskManagementExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaskManagement>> PostTaskManagement(TaskManagement taskManagement)
        {
            _context.TaskManagement.Add(taskManagement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskManagement", new { id = taskManagement.Id }, taskManagement);
        }

        // DELETE: api/Tasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskManagement(int id)
        {
            var taskManagement = await _context.TaskManagement.FindAsync(id);
            if (taskManagement == null)
            {
                return NotFound();
            }

            _context.TaskManagement.Remove(taskManagement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskManagementExists(int id)
        {
            return _context.TaskManagement.Any(e => e.Id == id);
        }
    }
}
