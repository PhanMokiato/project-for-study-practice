using System;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.UserId = id;
            return View();
        }
        
        [HttpPost]
        public IActionResult Form(User user)
        {
            var us = db.Users.FirstOrDefault(u=>u.PhoneNumber==user.PhoneNumber);
            if (us != null)
            {
                return RedirectToAction("Sorry");
            }
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Hello", user);
        }

        public IActionResult Sorry()
        {
           return View();
        }
        public IActionResult Hello(User user)
        {
            ViewData["Name"] = user.Name;
            return View();
        }
        
    }
}