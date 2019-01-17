using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Football_Shop.Models;

namespace Football_Shop.Controllers
{
    public class CartController : Controller
    {
        private FotballShopEntity db = new FotballShopEntity();

        private static List<Product> purchaseProducts = new List<Product>();

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Balls ball = db.Balls.Find(id);
            if (ball == null)
            {
                return HttpNotFound();
            }
            return View(ball);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Cart()
        {
          return View(purchaseProducts);
        }

        public ActionResult Add(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Balls ball = db.Balls.Find(id);
            Product product = purchaseProducts.Where(b => b.Ball.id_product == id).FirstOrDefault();

            if (product == null)
            {
                purchaseProducts.Add(new Product { Ball = ball });
            }

            return RedirectToAction("Boots", "Home");
        }

        public ActionResult Buy (int? id)
        {
            using (ProductContext db = new ProductContext())
            {
                Ball ball = db.Balls.Find(id);
                db.Balls.Add(new Ball { name_product = ball.name_product});
                db.SaveChanges();
            }
            
            return View();
        }

        public ActionResult Delete(int? id)
        {
            Balls ball = db.Balls.Find(id);
            Product product = purchaseProducts.Where(b => b.Ball.id_product == id).FirstOrDefault();

            if (product != null)
            {
                purchaseProducts.Remove(product);
            }
            return RedirectToAction("Boots", "Home");
        }
    }
}