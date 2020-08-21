using FoodPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPass.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            var payment = new Payment()
            {
                Amount = 100,
                LocationId = 2,
                ShopId = 20,
                UserId = 11
            };
            return View(payment);
        }
    }
}