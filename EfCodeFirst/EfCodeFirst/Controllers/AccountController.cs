using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EfCodeFirst.Models;

namespace EfCodeFirst.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            if (acc.User == "Admin" && acc.Password == "SoyTuRealAdministrador2020")
            {
                return RedirectToAction("Index", "BlogPosts");
            }
            else
            {
                ViewBag.Message = "User o Passwaord erroneas";              
                return RedirectToAction("Login", "Account");
            }

        }
    }
}