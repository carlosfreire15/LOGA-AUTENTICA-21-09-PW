using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Cookies;


[assembly: OwinStartup(typeof(AppLoginAutentication.App_Start.Startup))]

namespace AppLoginAutentication.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {

                AuthenticationType = "AppAplicationCookie",
                LoginPath = new PathString("Autenticacao/Login")


            });



        }
    }
}
