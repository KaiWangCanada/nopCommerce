using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web.Mvc;
using Nop.Web.Framework.Localization;

namespace Nop.Plugin.Misc.MyCustomPlugin.Infrastructure
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapLocalizedRoute("HomePagePlugin",
                            "",
                            new { controller = "Home", action = "Index" },
                            new[] { "Nop.Plugin.Misc.MyCustomPlugin.Controllers" });


        }
        public int Priority
        {
            get
            {
                return int.MaxValue; ;
            }
        }

    }
}