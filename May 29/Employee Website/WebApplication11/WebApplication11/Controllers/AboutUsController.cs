using Microsoft.AspNetCore.Mvc;

namespace WebApplication11.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
