using Nop.Core.Data;
using Nop.Plugin.Misc.TT.Domain;
using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Misc.TT.Controllers
{
    public class TTController : BasePluginController
    {
        private IRepository<TTRecord> _tRepository;

        public TTController(IRepository<TTRecord> tRepository)
        {
            _tRepository = tRepository;
        }

        public ActionResult Manage()
        {
            return View();
        }
    }
}
