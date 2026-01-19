using Microsoft.AspNetCore.Mvc;

namespace MiddlewareApp.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("")]
        [Route("~/Home")]
        
        // [Route("Index")]
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        // [Route("About")]
        public IActionResult About()
        {

            return View();
        }
        [Route("{id?}")]
        public int Details(int? id)
        {

            return id ?? 1;
        }

    }
}
