using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using ToDoApp.Data;

namespace ToDoApp.Models
{
    public class UserViewModel : User
    {
        [HiddenInput]
        public Int64 Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }
    }
}
