using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPass.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<Location> Locations { get; set; }
    }
}