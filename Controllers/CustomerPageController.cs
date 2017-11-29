using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreDemo.Controllers
{
    public class CustomerPageController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }
}