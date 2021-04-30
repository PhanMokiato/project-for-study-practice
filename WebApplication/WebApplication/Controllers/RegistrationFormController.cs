using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;


namespace WebApplication.Controllers
{
    public class RegistrationFormController : Controller
    {
        // GET
        MobileContext db;
        public RegistrationFormController(MobileContext context)
        {
            db = context;
        }
        
        public IActionResult Form()
        {
            var id = new Random();
            ViewBag.UserId = id.Next();
            return View();
        }
        
        [HttpPost]
        public string Form(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return "Hello, " + user.Name + "!";
            // return RedirectToAction("Hello");
        }
    }
}