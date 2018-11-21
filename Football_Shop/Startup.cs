using Microsoft.Owin;
using Owin;
using Football_Shop.Models;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Football_Shop.App_Start;

[assembly: OwinStartup(typeof(Football_Shop.Startup))]

namespace Football_Shop
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // настраиваем контекст и менеджер
            app.CreatePerOwinContext(ApplicationContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
    }
}