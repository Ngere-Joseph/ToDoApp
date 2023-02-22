using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ToDoApp.Data
{
    public class TodoMap
    {
        public TodoMap(EntityTypeBuilder<Todo> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.TaskName).IsRequired();
            entityBuilder.Property(t => t.TaskDescription).IsRequired();
            entityBuilder.Property(t => t.Category);
        }
    }
}
