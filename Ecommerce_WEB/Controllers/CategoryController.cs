using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_WEB.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
