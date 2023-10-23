using Microsoft.AspNetCore.Mvc;

namespace Heydaroghlu.com.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
