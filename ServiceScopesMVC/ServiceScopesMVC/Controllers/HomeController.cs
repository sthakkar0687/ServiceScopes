using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceScopesMVC.Models;
using ServiceScopesMVC.Services.Interfaces;
using System.Diagnostics;

namespace ServiceScopesMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingleton _singleton;
        private readonly IScoped _scoped;
        private readonly ITransient _transient;
        public HomeController(ILogger<HomeController> logger, ISingleton singleton, IScoped scoped, ITransient transient)
        {
            _logger = logger;
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }

        public IActionResult Index()
        {
            //_singleton.GetSingletonCount();
            //_transient.GetTransientCount();
            //_scoped.GetScopedCount();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
