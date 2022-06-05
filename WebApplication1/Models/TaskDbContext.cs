using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        { }

        public DbSet<Task> Tasks { get; set; }
        
    }
}
