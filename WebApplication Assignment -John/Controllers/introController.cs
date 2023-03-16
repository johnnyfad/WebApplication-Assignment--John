using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Assignment__John.Controllers
{
    public class introController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
