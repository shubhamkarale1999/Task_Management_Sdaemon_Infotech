//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Task_Management_Sdaemon_Infotech.Model;

namespace Task_Management_Sdaemon_Infotech.Data
{
    public class TaskManagementContext : DbContext
    {
        public TaskManagementContext(DbContextOptions<TaskManagementContext> options)
        : base(options)
        {
        }

        public DbSet<TaskManagement> TaskManagement { get; set; }
    }
}
