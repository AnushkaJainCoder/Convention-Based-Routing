using Microsoft.AspNetCore.Mvc;

namespace MiddlewareApp.Controllers
{
    // [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // -------------------------------viewdata--------------------------------
            // ViewData["data1"] = "Anushka From UP";
            // ViewData["data2"] = 23;
            // ViewData["data3"] = DateTime.Now.ToLongDateString();
            // string[] arr = {"Anushka", "Aman", "Amit", "Anjali", "Anita"};
            // ViewData["data4"] = arr;
            // ViewData["data5"] = new List<String>{
            //     "Cricket", "Football", "Hockey", "Tennis", "Basketball"
            // };

           
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
