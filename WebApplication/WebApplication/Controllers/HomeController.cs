using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    //MSSQL server
    public class HomeController : Controller
    {
        MobileContext db;
        public HomeController(MobileContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Flowers.ToList());
        }
        
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.FlowerId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Buy(Order order)
        {
            
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return RedirectToAction("ThankYou", order);
        }
        public IActionResult ThankYou(Order order)
        {
            ViewData["Name"] = order.User;
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
    }
}