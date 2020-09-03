using FoodPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPass.Controllers
{
    [Authorize]
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            var location = new Location()
            {
                Address = "Zajecar",
                AddressNumber = 5,
                City = "Zajecar",
                ShopId = 2,
                State = "Srbija"
            };
            return View(location);
        }
    }
}