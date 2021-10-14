using Microsoft.AspNetCore.Mvc;
using ServiceScopes.Services.Interfaces;

namespace ServiceScopes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ISingleton _singleton;
        private readonly IScoped _scoped;
        private readonly ITransient _transient;

        public HomeController(ISingleton singleton, IScoped scoped, ITransient transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok(new { Singleton = _singleton.GetSingletonCount(), Scoped = _scoped.GetScopedCount(), Transient = _transient.GetTransientCount() });
        }

    }
}
