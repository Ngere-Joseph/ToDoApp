using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Data;
using ToDoApp.Models;
using ToDoApp.Service;

namespace ToDoApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly ITodoService todoService;

        public UserController(IUserService userService, ITodoService taskService)
        {
            this.userService = userService;
            this.todoService = taskService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            List<UserViewModel> model = new List<UserViewModel>();
            userService.GetUsers().ToList().ForEach(u =>
            {
                User userProfile = userService.GetUser(u.Id);
                UserViewModel user = new UserViewModel
                {
                    Id = u.Id,
                    Name = $"{userProfile.UserName}",
                    Email = u.Email,


                };
                model.Add(user);
            });

            return View(model);
        }


        //POST: Student/Add
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add([Bind("UserName,Email")] User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            userService.InsertUser(user);
            return RedirectToAction(nameof(Index));
        }


        //Edit
        public ActionResult EditUser(int? id)
        {

            UserViewModel model = new UserViewModel();
            if (id.HasValue && id != 0)
            {
                User userEntity = userService.GetUser(id.Value);
                model.UserName = userEntity.UserName;
                model.Email = userEntity.Email;
            }
            return View(model);
            //    if (studentDetails == null) return View("NotFound");
            //return View(studentDetails);
        }

        [HttpPost]
        public ActionResult EditUser(UserViewModel model)
        {
            User userEntity = userService.GetUser(model.Id);
            userEntity.Email = model.Email;
            userEntity.UserName = model.UserName;

            userService.UpdateUser(userEntity);
            if (userEntity.Id > 0)
            {
                return RedirectToAction("index");
            }
            return View(model);
        }

    }

}
