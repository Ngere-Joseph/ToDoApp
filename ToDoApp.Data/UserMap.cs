using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ToDoApp.Data
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Email).IsRequired();
            entityBuilder.Property(t => t.Password);
            entityBuilder.Property(t => t.Email).IsRequired();
            entityBuilder.HasOne(t => t.Todo).WithOne(u => u.User).HasForeignKey<Todo>(x => x.Id);
        }
    }
}
