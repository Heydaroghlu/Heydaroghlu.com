using Microsoft.AspNetCore.Mvc;

namespace Heydaroghlu.com.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
