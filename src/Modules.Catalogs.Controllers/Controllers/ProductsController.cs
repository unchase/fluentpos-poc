using Microsoft.AspNetCore.Mvc;

namespace Modules.Catalogs.Controllers
{
    internal class ProductsController : BaseController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Catalogs module";
    }
}