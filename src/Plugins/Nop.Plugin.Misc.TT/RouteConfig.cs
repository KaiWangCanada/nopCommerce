using Nop.Plugin.Misc.TT.Infrastructure;
using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nop.Plugin.Misc.TT
{
    public class RouteConfig : IRouteProvider
    {
        public int Priority
        {
            get
            {
                return 0;
            }
        }

        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Misc.TT.ManageT",
                "TT/Manage",
                new { controller = "TT", action = "Manage" },
                new[] { "Nop.Plugin.Misc.TT.Controllers" }
            );

            ViewEngines.Engines.Insert(0, new CustomViewEngine());
        }
    }
}
