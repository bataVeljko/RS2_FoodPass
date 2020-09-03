using FoodPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPass.Controllers
{
    [Authorize]
    public class SellerController : Controller
    {
        // GET: Seller
        public ActionResult Index()
        {
            var seller = new Seller()
            {
                Age = 23,
                FirstName = "Milica",
                LastName = "Stevic"
            };
            return View(seller);
        }
    }
}