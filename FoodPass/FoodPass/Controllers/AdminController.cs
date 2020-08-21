using FoodPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPass.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var admin = new Admin()
            {
                Age = 24,
                FirstName = "Marko",
                LastName = "Veljkovic"
            }; 
            return View(admin); 
        }
    }
}