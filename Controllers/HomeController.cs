using Microsoft.AspNetCore.Mvc;
using ThirdMVCApp.DAL;
using ThirdMVCApp.Models;

namespace ThirdMVCApp.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            SecondMvcappDbContext db = new SecondMvcappDbContext();

            var u = db.Users.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {

            SecondMvcappDbContext db = new SecondMvcappDbContext();
            db.Users.Add(user);
            db.SaveChanges();


            return RedirectToAction("Index");
        }



        public IActionResult Delete(int id)
        {
            SecondMvcappDbContext db = new SecondMvcappDbContext();
            var user = db.Users.Find(id);

            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Update(int id)
        {
            SecondMvcappDbContext db = new SecondMvcappDbContext();
            var user = db.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {

            SecondMvcappDbContext db = new SecondMvcappDbContext();
            db.Users.Update(user);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
