using Microsoft.AspNetCore.Mvc;

namespace MiddlewareApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult About()
        {
           
            return View();
        }
        public int Details(int id)
        {
           
            return id;
        }
        
    }
}
