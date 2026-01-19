using Microsoft.AspNetCore.Mvc;

namespace MiddlewareApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
