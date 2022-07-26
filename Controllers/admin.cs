using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class admin : Controller
    {
        private readonly DataContext db;
        public admin(DataContext context)
        {
            db = context;
        }
        public IActionResult LoginForm()
        {

            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult LoginForm(Admin log)
        {
            var Vaild = db.Admin.Where(admin => admin.AdminUserName == log.AdminUserName && admin.AdminPassword == log.AdminPassword).Count();
            if (Vaild > 0)
            {
                HttpContext.Session.SetString("IsAdmin", "true");

                return RedirectToAction("Index", "Home");

            }

            return View();
        }

        public IActionResult adminLogout()
        {
            HttpContext.Session.SetString("IsAdmin", "false");
            
            return RedirectToAction("Index", "Home"); 

        }

    }
}
