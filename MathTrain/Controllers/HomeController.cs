using Microsoft.AspNetCore.Mvc;

namespace MathTrain.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Theory() => View();
        public IActionResult Testing() => View();
        public IActionResult Autors() => View();

        

        public void CheckLoging()
        {

        }
    }
}
