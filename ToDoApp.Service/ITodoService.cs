using ToDoApp.Data;

namespace ToDoApp.Service
{
    public interface ITodoService
    {
        Todo GetTodo(long id);
    }
}
