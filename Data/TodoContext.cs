using Microsoft.EntityFrameworkCore;
using ToDoList.Models; // Ajuste conforme o namespace do seu modelo

namespace ToDoList.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}