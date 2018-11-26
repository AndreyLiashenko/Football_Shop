using Football_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Football_Shop.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Customer customer = null;
                using (CustomerContext db = new CustomerContext())
                {
                    customer = db.Customers.FirstOrDefault(u => u.Email == model.Name);
                }
                if (customer == null)
                {
                    // создаем нового пользователя
                    using (CustomerContext db = new CustomerContext())
                    {
                        db.Customers.Add(new Customer { Email = model.Name, password = model.Password });
                        db.SaveChanges();

                        customer = db.Customers.Where(u => u.Email == model.Name && u.password == model.Password).FirstOrDefault();
                    }
                    // если пользователь удачно добавлен в бд
                    if (customer != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Name, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }

            return View(model);
        }
    }
}