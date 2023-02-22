using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;

namespace ToDoApp.Repo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserMap(modelBuilder.Entity<User>());
            new TodoMap(modelBuilder.Entity<Todo>());
        }
    }
}
