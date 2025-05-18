using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_Management_Sdaemon_Infotech.Data;
using Task_Management_Sdaemon_Infotech.Model;

namespace Task_Management_Sdaemon_Infotech.Controllers
{
    public class TaskManagementsUIController : Controller
    {
        private readonly TaskManagementContext _context;

        public TaskManagementsUIController(TaskManagementContext context)
        {
            _context = context;
        }

        // GET: TaskManagementsUI
        public async Task<IActionResult> Index()
        {
            return View(await _context.TaskManagement.ToListAsync());
        }

        // GET: TaskManagementsUI/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskManagement = await _context.TaskManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taskManagement == null)
            {
                return NotFound();
            }

            return View(taskManagement);
        }

        // GET: TaskManagementsUI/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaskManagementsUI/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,DueDate,IsComplete,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] TaskManagement taskManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taskManagement);
        }

        // GET: TaskManagementsUI/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskManagement = await _context.TaskManagement.FindAsync(id);
            if (taskManagement == null)
            {
                return NotFound();
            }
            return View(taskManagement);
        }

        // POST: TaskManagementsUI/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,DueDate,IsComplete,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] TaskManagement taskManagement)
        {
            if (id != taskManagement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskManagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskManagementExists(taskManagement.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(taskManagement);
        }

        // GET: TaskManagementsUI/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskManagement = await _context.TaskManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taskManagement == null)
            {
                return NotFound();
            }

            return View(taskManagement);
        }

        // POST: TaskManagementsUI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskManagement = await _context.TaskManagement.FindAsync(id);
            if (taskManagement != null)
            {
                _context.TaskManagement.Remove(taskManagement);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskManagementExists(int id)
        {
            return _context.TaskManagement.Any(e => e.Id == id);
        }
    }
}
