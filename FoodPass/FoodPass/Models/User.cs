﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPass.Models
{
    abstract class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
}