﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGeek.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageName { get; set; }
        public List<Product> ShoppingCart { get; set; } = new List<Product>();
        public int Quantity { get; set; }
    }

}