using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Football_Shop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {

        }
    }

    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext()
            : base("Football_ShopEntities")
        {
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}