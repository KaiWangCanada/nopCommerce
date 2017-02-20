using Nop.Core.Data;
using Nop.Plugin.Misc.TT.Domain;
using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Nop.Services.Catalog;

namespace Nop.Plugin.Misc.TT.Controllers
{
    public class TTController : BasePluginController
    {
        private IProductService _productService;
        private IRepository<TTRecord> _tRepository;

        public TTController(IRepository<TTRecord> tRepository, IProductService productService)
        {
            _tRepository = tRepository;
            _productService = productService;
        }

        public ActionResult Manage()
        {
            return View();
        }

        public ActionResult NE()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NE([Bind(Include="CustomName, ProductId")]TTRecord vm)
        {
            if (ModelState.IsValid)
            {
                var product = _productService.GetProductById(vm.ProductId);

                _tRepository.Insert(vm);
                return View("_DL", vm);
            }
            else
            {
                return View();
            }
        }
    }
}
