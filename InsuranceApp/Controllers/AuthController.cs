using Microsoft.AspNetCore.Mvc;

namespace InsuranceApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {

        return View(); 

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
