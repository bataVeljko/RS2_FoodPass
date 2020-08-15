using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPass.Models
{
    public class Item
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}