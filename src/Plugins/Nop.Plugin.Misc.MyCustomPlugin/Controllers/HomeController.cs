using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Nop.Web.Framework.Security;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework;

namespace Nop.Plugin.Misc.MyCustomPlugin.Controllers
{
    public class HomeController : BasePluginController
    {
        [NopHttpsRequirement(SslRequirement.No)]
        public ActionResult Index()
        {
            return View("~/Plugins/Misc.MyCustomPlugin/Views/Home/Index.cshtml");
        }
    }
}