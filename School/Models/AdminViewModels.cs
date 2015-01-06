using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Models
{
    public class AdminViewModels
    {
    }

    public class AdminViewModel
    {
        public List<UserWithRoles> Users { get; set; }
    }

    public class UserWithRoles {
        public string UserName { get; set; }
        public bool IsStudent { get; set; }
        public bool IsTeacher { get; set; }
        public bool IsAdmin { get; set; }

    }
}