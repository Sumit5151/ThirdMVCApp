using Microsoft.AspNetCore.Mvc;
using ThirdMVCApp.Models;

namespace ThirdMVCApp.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            SecondMvcappDbContext db = new SecondMvcappDbContext();
              var users= db.Users.ToList();

            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }


    }
}
