using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football_Shop.Models
{
    public class Product
    {
        public Balls Ball { get; set; }

        public Customers Customer { get; set; }

        public PurchaseBalls PurchaseProduct {get;set;}

        public int Quantity { get; set; }
        
    }
}