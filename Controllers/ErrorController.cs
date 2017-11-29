using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreDemo.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}