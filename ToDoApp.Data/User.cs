namespace ToDoApp.Data
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Todo Todo { get; set; }
    }
}
