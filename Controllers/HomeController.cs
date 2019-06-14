using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private WeddingContext context;

        public HomeController(WeddingContext DbContext)
        {
            context = DbContext;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(RegUser user)
        {
            if (ModelState.IsValid)
            {
                if (context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                }
                string[] keys = HttpContext.Session.Keys.ToArray();
                if (keys.Contains("count"))
                {
                    int? count = HttpContext.Session.GetInt32("count");
                    HttpContext.Session.SetInt32("count", (int)count + 1);
                }
                else
                {
                    HttpContext.Session.SetInt32("count", 1);
                }
                ViewBag.Count = HttpContext.Session.GetInt32("count");

                PasswordHasher<RegUser> Hasher = new PasswordHasher<RegUser>();
                user.Password = Hasher.HashPassword(user, user.Password);
                context.Add(user);
                context.SaveChanges();
                return View("Dashboard");
            }
            return Redirect("/");
        }

        [HttpPost("login")]
        public IActionResult Login(LogUser user)
        {
            if (ModelState.IsValid)
            {
                var userInDb = context.Users.FirstOrDefault(u => u.Email == user.Email);
                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }
                string[] keys = HttpContext.Session.Keys.ToArray();
                if (keys.Contains("count"))
                {
                    int? count = HttpContext.Session.GetInt32("count");
                    HttpContext.Session.SetInt32("count", (int)count + 1);
                }
                else
                {
                    HttpContext.Session.SetInt32("count", 1);
                    return Redirect("/");
                }
                ViewBag.Count = HttpContext.Session.GetInt32("count");
                var hasher = new PasswordHasher<LogUser>();
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.Password);
                Console.WriteLine(ViewBag.Count);
                if (result == 0)
                {
                    return Redirect("/");
                }
                return RedirectToAction("Dashboard");
            }
            return Redirect("/");
        }

        [HttpGet("dashboard/")]
        public IActionResult Dashboard() {
            ViewBag.Weddings = context.Weddings.Include(w => w.Guests).ToList();
            return View(ViewBag.Weddings);
        }

        [HttpGet("newwedding")]
        public IActionResult NewWedding() {
            return View("AddWedding");
        }

        [HttpPost("createwedding")]
        public IActionResult CreateWedding(Wedding w) {
            if (ModelState.IsValid) {
                context.Create(w);
                Console.WriteLine(w);
            }
            return Redirect("dashboard");
        }

        [HttpGet("wed/{WedId}")]
        public IActionResult IdPage(int WedId) {
            ViewBag.WedId = context.Weddings.Select(w => w.WedId);
            return View();
        }



















        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }


    }
}
