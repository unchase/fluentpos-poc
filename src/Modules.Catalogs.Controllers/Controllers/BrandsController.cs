using Microsoft.AspNetCore.Mvc;

namespace Modules.Catalogs.Controllers
{
    internal class BrandsController : BaseController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Brands module";
    }
}