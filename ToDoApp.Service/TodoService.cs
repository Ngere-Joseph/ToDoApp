using ToDoApp.Data;
using ToDoApp.Repo;

namespace ToDoApp.Service
{
    public class TodoService : ITodoService
    {
        private IRepository<Todo> todoRepository;

        public TodoService(IRepository<Todo> todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public Todo GetTodo(long id)
        {
            return todoRepository.Get(id);
        }
    }
}
