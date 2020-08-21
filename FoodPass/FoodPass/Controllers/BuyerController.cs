using FoodPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPass.Controllers
{
    public class BuyerController : Controller
    {
        // GET: Buyer
        public ActionResult Index()
        {
            var buyer = new Buyer()
            {
                Age = 20,
                FirstName = "Mladen",
                LastName = "Veljkovic"
            };
            return View(buyer);
        }
    }
}