using Microsoft.AspNetCore.Mvc;


namespace ThirdMVCApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Registration()
        {
           
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Registration(User user)
        {
            if (ModelState.IsValid == true)
            {
                SecondMvcappDbContext db = new SecondMvcappDbContext();
                db.Users.Add(user);
                db.SaveChanges();
            }
            return View(user);
        }
    }
}
