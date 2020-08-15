using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPass.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int UserId { get; set; }
    }
}