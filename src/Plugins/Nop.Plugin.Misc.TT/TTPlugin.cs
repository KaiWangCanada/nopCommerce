using Nop.Core.Data;
using Nop.Core.Plugins;
using Nop.Plugin.Misc.TT.Data;
using Nop.Plugin.Misc.TT.Domain;
using Nop.Web.Framework.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace Nop.Plugin.Misc.TT
{
    public class TTPlugin : BasePlugin, IAdminMenuPlugin
    {
        private TTRecordObjectContext _context;
        private IRepository<TTRecord> _ttRepo;

        public TTPlugin(TTRecordObjectContext context, IRepository<TTRecord> ttRepo)
        {
            _context = context;
            _ttRepo = ttRepo;
        }

        public void ManageSiteMap(SiteMapNode rootNode)
        {
            // todo change controller, action
            var menuItem = new SiteMapNode()
            {
                SystemName = "Misc.TT",
                Title = "TT Title",
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

        public override void Install()
        {
            _context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            _context.Uninstall();
            base.Uninstall();
        }
    }
}
