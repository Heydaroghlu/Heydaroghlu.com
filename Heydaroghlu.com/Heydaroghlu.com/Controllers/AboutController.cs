using Microsoft.AspNetCore.Mvc;

namespace Heydaroghlu.com.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
