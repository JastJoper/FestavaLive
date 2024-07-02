using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public ActionResult MessageDelete(int id)
        {
           var values = context.Messages.Find(id);
            context.Messages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MessageDetail(int id)
        {
            var values = context.Messages.Find(id);
            return View(values);
        }
    }
}