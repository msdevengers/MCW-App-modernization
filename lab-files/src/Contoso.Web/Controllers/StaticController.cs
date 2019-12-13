using Contoso.Web.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Contoso.Web.Controllers
{
    [Authorize]
    public class StaticController : Controller
    {
        private readonly IConfiguration _configuration;

        public StaticController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var config = new WebAppConfiguration
            {
                ApiUrl = _configuration["ApiUrl"],
                PolicyDocumentsPath = _configuration["PolicyDocumentsPath"],
                ApimSubscriptionKey = _configuration["ApimSubscriptionKey"]
            };
            return View(config);
        }

        public IActionResult Dependents()
        {
            return View();
        }

        public IActionResult Dependent()
        {
            return View();
        }

        public IActionResult People()
        {
            return View();
        }

        public IActionResult Person()
        {
            return View();
        }

        public IActionResult Policies()
        {
            return View();
        }

        public IActionResult Policy()
        {
            return View();
        }

        public IActionResult PolicyHolders()
        {
            return View();
        }

        public IActionResult PolicyHolder()
        {
            return View();
        }
    }
}