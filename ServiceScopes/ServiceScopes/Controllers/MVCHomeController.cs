using Microsoft.AspNetCore.Mvc;
using ServiceScopes.Services.Interfaces;

namespace ServiceScopes.Controllers
{
    public class MVCHomeController : Controller
    {
        private readonly ISingleton _singleton;
        private readonly IScoped _scoped;
        private readonly ITransient _transient;
        public MVCHomeController(ISingleton singleton, IScoped scoped, ITransient transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }
        public IActionResult Index()
        {
            _singleton.GetSingletonCount();
            _transient.GetTransientCount();
            _scoped.GetScopedCount();
            return View();
        }
    }
}
