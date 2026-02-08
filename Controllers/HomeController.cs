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



            // -------------------------------viewbag--------------------------------
            // ViewBag.data1 = "Anushka From UP";
            // ViewBag.data2 = 21;
            // ViewBag.data3 = DateTime.Now.ToLongDateString();
            // string[] arr = {"Anushka", "Aman", "Amit", "Anjali", "Anita"};
            // ViewBag.data4 = arr;
            // ViewBag.data5 = new List<String>{
            //     "Cricket", "Football", "Hockey", "Tennis", "Basketball"
            // };
            // ViewData["data6"] = "AJ";


            ViewData["data1"] = "ViewData";
            ViewBag.data2 = "ViewBag";
            TempData["data3"] = "TempData";
            TempData.Keep("data3");
            // return RedirectToAction("About");
            return View();
        }
        public IActionResult About()
        {
            TempData.Keep("data3");
            return View();
        }
        public IActionResult Contact()
        {
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
