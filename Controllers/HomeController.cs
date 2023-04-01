﻿using Microsoft.AspNetCore.Mvc;
using ThirdMVCApp.Models;

namespace ThirdMVCApp.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            SecondMvcappDbContext db = new SecondMvcappDbContext();

            var users = db.Users.ToList();
            //var employees = db.Employees.ToList();
            //var teachers= db.Teachers.ToList();           

            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            User user= new User();
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


        public IActionResult Update()
        {
            return View();
        }


    }
}
