#region Includes

// .NET Libraries
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

// MovieBox Libraries
using DataAccess;
using Entities;
using MovieBox.Web.App_Start;

#endregion

namespace MovieBox.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Start AutoMapper
            AutoMapperConfig.Start();
        }
    }
}
