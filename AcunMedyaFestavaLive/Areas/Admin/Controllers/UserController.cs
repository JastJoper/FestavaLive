using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        Context context = new Context();
        public ActionResult UserList()
        {
            var values = context.Users.ToList();
            return View(values);
        }
           
        public ActionResult DeleteUser(int id)
        {
            var value = context.Users.Find(id);
            context.Users.Remove(value);
            context.SaveChanges();
            return RedirectToAction("UserList");
        }
    }
}