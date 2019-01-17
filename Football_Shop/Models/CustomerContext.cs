using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Football_Shop.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("FotballShopEntity")
        {

        }
         
        public DbSet<Customers> Customers { get; set; }
    }
}