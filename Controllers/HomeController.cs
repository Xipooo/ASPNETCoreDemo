using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}