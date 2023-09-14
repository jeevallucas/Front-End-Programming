using Microsoft.AspNetCore.Components;
namespace Controller;

public class TodoBase : ComponentBase
{
    protected List<TodoItem> todos = new();
    protected string? newTodo;

    protected void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            newTodo = string.Empty;
        }
    }
}