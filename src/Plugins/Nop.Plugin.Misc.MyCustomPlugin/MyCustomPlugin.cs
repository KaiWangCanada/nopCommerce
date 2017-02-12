using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using Nop.Core.Plugins;
using Nop.Services.Common;
using Nop.Web.Framework.Menu;

namespace Nop.Plugin.Misc.MyCustomPlugin
{
    public class MyCustomPlugin : BasePlugin, IMiscPlugin, IAdminMenuPlugin
    {
        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "MyCustomPlugin";
            routeValues = new RouteValueDictionary { { "Namespaces", "Nop.Plugin.Misc.MyCustomPlugin.Controllers" }, { "area", null } };
        }

        public void ManageSiteMap(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode()
            {
                SystemName = "MyCustomPlugin",
                Title = "MyCustomPlugin Title",
                ControllerName = "TT",
                ActionName = "Manage",
                Visible = true,
                RouteValues = new RouteValueDictionary() { { "area", null } },
            };
            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Third party plugins");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);
        }
    }
}