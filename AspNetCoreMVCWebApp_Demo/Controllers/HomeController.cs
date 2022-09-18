using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCWebApp_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
