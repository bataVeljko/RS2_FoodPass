using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPass.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

    }
}