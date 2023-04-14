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

            SecondMvcappDbContext db = new SecondMvcappDbContext();
            var genders = db.Genders.ToList();
            ViewBag.GenderList = genders;

            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Registration(User user)
        {
            SecondMvcappDbContext db = new SecondMvcappDbContext();
            if (ModelState.IsValid == true)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index", "User");
            }
            var genders = db.Genders.ToList();
            ViewBag.GenderList = genders;
            return View(user);
        }



        public IActionResult IsEmailIdValid(string Email)
        {
            SecondMvcappDbContext db = new SecondMvcappDbContext();

            var isEmailIdPresentInDB = db.Users.Any(u => u.Email == Email);
            if (isEmailIdPresentInDB == true)
            {
                return Json("The Email id is present in the database please choose another email id");
            }
            else
            {
                return Json(true);
            }



        }
    }
}
