using FoodPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPass.Controllers
{
    public class SupportController : Controller
    {
        // GET: Support
        public ActionResult Index()
        {
            var support = new Support()
            {
                Age = 40,
                FirstName = "Janko",
                LastName = "Ivanovic"
            };
            return View(support);
        }
    }
}