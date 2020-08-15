using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPass.Models
{
    public class Location
    {
        public int Id { get; set; }
        public String State { get; set; }
        public String City { get; set; }
        public String Address { get; set; }
        public int AddressNumber { get; set; }
        public int ShopId { get; set; }
    }
}