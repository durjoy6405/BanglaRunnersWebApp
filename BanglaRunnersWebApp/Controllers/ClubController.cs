using Microsoft.AspNetCore.Mvc;

namespace BanglaRunnersWebApp.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
