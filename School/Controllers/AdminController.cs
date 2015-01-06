using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            var ctx = new ApplicationDbContext();
            var manager = new IdentityManager();
            var model = new AdminViewModel();
            var users = ctx.Users;
            var userWithRoles = new List<UserWithRoles>();
            var allRoles = ctx.Roles;
            foreach (var user in users)
            {
                var currentUser = new UserWithRoles();
                currentUser.UserName = user.UserName;
                try
                {
                    var studentCond = user.Roles.FirstOrDefault(u => u.Role.Name == "Student");
                    if (studentCond != null) currentUser.IsStudent = true;
                    else currentUser.IsStudent = false;
                    var teacherCond = user.Roles.FirstOrDefault(u => u.Role.Name == "Teacher");
                    if (teacherCond != null) currentUser.IsTeacher = true;
                    else currentUser.IsTeacher = false;
                    var adminCond = user.Roles.FirstOrDefault(u => u.Role.Name == "Admin");
                    if (adminCond != null) currentUser.IsAdmin = true;
                    else currentUser.IsAdmin = false;
                }
                catch (Exception e)
                {
                    Console.Write(e.Data);
                }
                userWithRoles.Add(currentUser);
            }
            model.Users = userWithRoles;
            return View(model);
        }
	}
}