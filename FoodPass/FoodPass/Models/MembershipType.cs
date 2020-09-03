using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPass.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public short Fee { get; set; }
        public byte DurationInMonths { get; set; }

    }
}