using Football_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Football_Shop.Controllers
{
    public class HomeController : Controller
    {
        FotballShopEntity fs = new FotballShopEntity();

        public ActionResult Index()
        {
            return View();
        }

       // [HttpGet]
        public ActionResult Boots()
        {
            return View(fs.Balls);
        }
        
        public ActionResult DiscountBoots()
        {
            return View();
        }
    }
}