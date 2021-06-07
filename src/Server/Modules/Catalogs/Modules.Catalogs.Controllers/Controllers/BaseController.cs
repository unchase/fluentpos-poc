using Microsoft.AspNetCore.Mvc;

namespace Modules.Catalogs.Controllers
{
    [ApiController]
    [Route(BasePath + "/[controller]")]
    internal abstract class BaseController : ControllerBase
    {
        protected const string BasePath = "api/catalog";
    }
}