using FoodPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPass.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult Index()
        {
            var transaction = new Transaction()
            {
                UserId = 3,
                Amount = 122
            };
            return View(transaction);
        }
    }
}