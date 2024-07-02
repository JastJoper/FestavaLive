using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Controllers
{
    
    public class DefaultController : Controller
    {
        Context context = new Context();
        
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = context.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }

        public PartialViewResult PartialMeetArtist()
        {
            var values = context.Artists.OrderBy(x => x.ArtistID).Take(4).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEventSchedule()
        {
            return PartialView();
        }
        public PartialViewResult PartialTicket()
        {
            var values = context.Tickets.Where(x => x.Status == true).OrderBy(x => x.TicketID).Take(4).ToList();  
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialContact(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

    }
}