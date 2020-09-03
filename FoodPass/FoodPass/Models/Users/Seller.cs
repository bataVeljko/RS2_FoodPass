using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPass.Models
{
    public class Seller : User
    {
        public int ShopId { get; set; }
    }
}