using System.Collections.Generic;
using ToDoApp.Data;
using ToDoApp.Repo;

namespace ToDoApp.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> userRepository;
        private IRepository<Todo> todoRepository;

        public UserService(IRepository<User> userRepository, IRepository<Todo> todoRepository)
        {
            this.userRepository = userRepository;
            this.todoRepository = todoRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public User GetUser(long id)
        {
            return userRepository.Get(id);
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }
        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }
    }
}
