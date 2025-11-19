using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Models;
using Microsoft.AspNetCore.Mvc;



[ApiController]
[Route("api/[controller]")]
public class TodoController: ControllerBase
{
    public readonly TodoContext _context;

    public TodoController(TodoContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodos()
    {
        return await _context.TodoItems.ToListAsync();
    }
   [HttpPost]
    public async Task<ActionResult<TodoItem>> CreateTodo(TodoItem item)
    {
        _context.TodoItems.Add(item);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTodos), new { id = item.Id }, item);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTodo(int id, TodoItem item)
    {
        if (id != item.Id) return BadRequest();
        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodo(int id)
    {
        var todo = await _context.TodoItems.FindAsync(id);
        if (todo == null) return NotFound();
        _context.TodoItems.Remove(todo);
        await _context.SaveChangesAsync();
        return NoContent();
    }

}