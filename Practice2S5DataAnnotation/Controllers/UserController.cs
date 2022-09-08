using Practice2S5DataAnnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice2S5DataAnnotation.Controllers
{
    public class UserController : Controller
    {
        public static List<User> users = new List<User>()
        {
            new User
            {
                id = 1,
                name = "Sơn",
                email = "bibop1125@gmail.com"
            },
            new User
            {
                id = 2,
                name = "Linh",
                email = "abc123@gmail.com"
            },
            new User
            {
                id = 3,
                name = "Trang",
                email = "def456@gmail.com"
            }
        };

        // GET: User
        public ActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", user);
                }
                users.Add(user);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            User user = users.Find(u => u.id == id);
            return View(user);
        }
    }
}