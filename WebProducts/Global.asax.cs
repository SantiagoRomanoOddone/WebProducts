using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebProducts.Data;

namespace WebProducts
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // COMO ACTIVAR LA CLASE INICIALIZADORA
            //Database.SetInitializer<ProductDbContext>(new ProductsInitializer());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
