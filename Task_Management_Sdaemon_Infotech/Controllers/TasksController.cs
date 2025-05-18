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
            try
            {
                return Ok(await _context.TaskManagement.ToListAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Internal server error", details = ex.Message });
            }
        }

        // GET: api/Tasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskManagement>> GetTaskManagement(int id)
        {
            try
            {
                var task = await _context.TaskManagement.FindAsync(id);
                if (task == null)
                {
                    return NotFound(new { error = "Task not found" });
                }
                return Ok(task);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error retrieving task", details = ex.Message });
            }
        }

        // PUT: api/Tasks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskManagement(int id, TaskManagement taskManagement)
        {
            if (id != taskManagement.Id)
                return BadRequest(new { error = "Task ID mismatch" });

            _context.Entry(taskManagement).State = EntityState.Modified;

            try
            {
                taskManagement.UpdatedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return Ok(new { message = "Task updated successfully" });
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskManagementExists(id))
                {
                    return NotFound(new { error = "Task not found" });
                }
                else
                {
                    return StatusCode(500, new { error = "Concurrency error while updating task" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error updating task", details = ex.Message });
            }
        }

        // POST: api/Tasks
        [HttpPost]
        public async Task<ActionResult<TaskManagement>> PostTaskManagement(TaskManagement taskManagement)
        {
            try
            {
                taskManagement.CreatedDate = DateTime.Now;
                _context.TaskManagement.Add(taskManagement);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetTaskManagement), new { id = taskManagement.Id }, taskManagement);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error creating task", details = ex.Message });
            }
        }

        // DELETE: api/Tasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskManagement(int id)
        {
            try
            {
                var task = await _context.TaskManagement.FindAsync(id);
                if (task == null)
                {
                    return NotFound(new { error = "Task not found" });
                }

                _context.TaskManagement.Remove(task);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Task deleted successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error deleting task", details = ex.Message });
            }
        }

        private bool TaskManagementExists(int id)
        {
            return _context.TaskManagement.Any(e => e.Id == id);
        }
    }
}
