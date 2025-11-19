using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using CarShopManagementSystemMVC.Models;

namespace CarShopManagementSystemMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Features()
        {
            return View();
        }

        public ActionResult NewCar()
        {
            return View();
        }

        public ActionResult Brand()
        {
            return View();
        }

       

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registartion(TblUser r1)
        {
            using (CarShopDTOEntities db = new CarShopDTOEntities())
            {
                if (ModelState.IsValid)
                {
                    db.TblUsers.Add(r1);
                    db.SaveChanges();
                    ViewBag.message("Registration Sucessfully");
                    ModelState.Clear();
                }
            }
            return View(r1);
        }
        [HttpPost]
        public ActionResult Login(TblUser r1)
        {
            using (CarShopDTOEntities db = new CarShopDTOEntities())
            {
                if (ModelState.IsValid)
                {
                    var log = db.TblUsers.Where(a => a.userName.Equals(r1.userName) && a.password.Equals(r1.password)).FirstOrDefault();
                    if (log != null)
                    {
                        return RedirectToAction("Contact");
                    }

                    ViewBag.message("Login Sucessfully");
                    ModelState.Clear();
                }
            }
            return View(r1);
        }

    }
}