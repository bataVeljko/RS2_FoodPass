using FoodPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPass.Controllers
{
    [Authorize]
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            var item = new Item()
            {
                Name = "Smoki",
                Price = 48,
                Quantity = 87
            };
            return View(item);
        }
    }
}