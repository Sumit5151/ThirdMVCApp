using Microsoft.AspNetCore.Mvc;
using ThirdMVCApp.DAL;

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

            UserRegistrationViewModel userVM = new UserRegistrationViewModel();
            return View(userVM);
        }

        [HttpPost]
        public IActionResult Registration(UserRegistrationViewModel userVM)
        {
            SecondMvcappDbContext db = new SecondMvcappDbContext();
            if (ModelState.IsValid == true)
            {
                //convert from UserViewModel to UserDTO model
                User user = new User(); //DTO
                user.Email = userVM.Email;
                user.FirstName = userVM.FirstName;
                user.LastName = userVM.LastName;
                user.GenderId = userVM.GenderId;
                user.Password = userVM.Password;
                user.MobileNumber = userVM.MobileNumber;



                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index", "User");
            }
            var genders = db.Genders.ToList();
            ViewBag.GenderList = genders;
            return View(userVM);
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
