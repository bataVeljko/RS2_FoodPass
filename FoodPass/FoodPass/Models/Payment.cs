using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPass.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public int UserId { get; set; }
        public int ShopId { get; set; }
        public int LocationId { get; set; }
    }
}