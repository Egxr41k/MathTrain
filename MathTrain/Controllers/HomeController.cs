using Microsoft.AspNetCore.Mvc;
using MathTrain.Models;
using System.Diagnostics;

namespace MathTrain.Controllers
{
    public class HomeController : Controller
    {
        //private ApplicationDbContext dbContext;
        //public HomeController(ApplicationDbContext context)
        //{
        //    dbContext = context;
        //}
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index() => View();
        public IActionResult Testing() => View();
        public IActionResult Autors() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
