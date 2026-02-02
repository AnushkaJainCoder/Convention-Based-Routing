using Microsoft.AspNetCore.Mvc;

namespace MiddlewareApp.Controllers
{
    // [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult About()
        {

            return View();
        }
        public IActionResult Contact(){
            return View();
        }














        // [Route("~/")]
        // [Route("")]
        // [Route("~/Home")]
        
        // [Route("Index")]
        // public IActionResult Index()
        // {
        //     // return View("~/Views/Home/Index.cshtml");
        //     return View();
        // }
        // // [Route("About")]
        // public IActionResult About()
        // {

        //     return View();
        // }
        // public IActionResult Contact(){
        //     return View();
        // }
        // [Route("{id?}")]
        // public int Details(int? id)
        // {

        //     return id ?? 1;
        // }

    }
}
