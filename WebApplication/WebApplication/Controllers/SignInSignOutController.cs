using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using System;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class SignInSignOutController : Controller
    {
        MobileContext db;
        public SignInSignOutController(MobileContext context)
        {
            db = context;
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            var us = db.Users.FirstOrDefault(u => u.PhoneNumber == user.PhoneNumber);
            if (us != null && us.Password == user.Password)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("NoSuchUser");
        }

        public IActionResult NoSuchUser()
        {
            return View();
        }
        
    }
}