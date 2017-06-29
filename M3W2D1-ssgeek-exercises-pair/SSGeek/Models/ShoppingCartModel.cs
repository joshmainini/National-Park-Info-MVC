using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;

namespace SSGeek.Models
{
    public class ShoppingCartModel
    {
        public List<Product> ShoppingCart { get; set; } = new List<Product>();
        public int Quantity { get; set; }
    }
}