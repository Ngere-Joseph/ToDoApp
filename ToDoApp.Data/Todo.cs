namespace ToDoApp.Data
{
    public class Todo : BaseEntity
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string Category { get; set; }
        public virtual User User { get; set; }
    }
}
