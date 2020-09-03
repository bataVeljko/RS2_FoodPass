using FoodPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPass.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            var shop = new Shop()
            {
                Name = "Amin"
            };
            return View(shop);
        }
    }
}