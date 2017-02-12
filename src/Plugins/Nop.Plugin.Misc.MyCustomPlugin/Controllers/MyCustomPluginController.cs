using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Nop.Web.Framework.Controllers;
namespace Nop.Plugin.Misc.MyCustomPlugin.Controllers
{
    [AdminAuthorize]
    public class MyCustomPluginController : BasePluginController
    {
        public ActionResult Configure()
        {
            return View("~/Plugins/Misc.MyCustomPlugin/Views/MyCustomPlugin/Configure.cshtml", null);
        }
    }
}