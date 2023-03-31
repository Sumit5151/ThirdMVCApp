using Microsoft.AspNetCore.Mvc;

namespace ThirdMVCApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
