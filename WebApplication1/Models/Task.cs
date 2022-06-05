using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }
        public bool IsCompleted { get; set; }
    }
}
