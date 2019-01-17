using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Football_Shop.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("FotballShopEntity")
        {

        }

        public DbSet<Ball> Balls { get; set; }
    }
}