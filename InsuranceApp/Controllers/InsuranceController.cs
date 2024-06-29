using Microsoft.AspNetCore.Mvc;

namespace InsuranceApp.Controllers
{
    public class InsuranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
