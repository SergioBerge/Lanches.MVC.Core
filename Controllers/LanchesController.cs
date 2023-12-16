using Microsoft.AspNetCore.Mvc;

namespace Lanches.MVC.Core.Controllers
{
    public class LanchesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
