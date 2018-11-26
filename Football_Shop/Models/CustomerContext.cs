using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Football_Shop.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("Football_ShopEntities")
        {

        }
         
        public DbSet<Customer> Customers { get; set; }
    }
}