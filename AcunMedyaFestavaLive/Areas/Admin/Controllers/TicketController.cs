using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class TicketController : Controller
    {
        Context context = new Context();
        
        public ActionResult TicketList()
        {
            var values = context.Tickets.Where(x => x.Status == true).ToList(); 
            return View(values);
        }

        public ActionResult PassiveTicketList()
        {
            var values = context.Tickets.Where(x => x.Status == false).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTicket()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTicket(Ticket ticket)
        {
            ticket.Status = true;
            context.Tickets.Add(ticket);
            context.SaveChanges();
            return RedirectToAction("TicketList");
        }
        public ActionResult DeleteTicket (int id)
        {
            var values =context.Tickets.Find(id);
            context.Tickets.Remove(values);
            context.SaveChanges();
            return RedirectToAction("TicketList");
        }
        [HttpGet]
        public ActionResult UpdateTicket(int id)
        {
            var values = context.Tickets.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTicket(Ticket ticket)
        {
            var values = context.Tickets.Find(ticket.TicketID);
            values.TicketProperty1 = ticket.TicketProperty1;
            values.TicketProperty2 = ticket.TicketProperty2;
            values.TicketProperty3 = ticket.TicketProperty3;
            values.TicketProperty4 = ticket.TicketProperty4;
            values.TicketProperty5 = ticket.TicketProperty5;
            values.TicketProperty6 = ticket.TicketProperty6;
            values.Title = ticket.Title;
            values.Description = ticket.Description;
            values.Price = ticket.Price;
            context.SaveChanges();
            return RedirectToAction("TicketList");
        }

        public ActionResult TicketDetail(int id)
        {
           var values = context.Tickets.Find(id);
            return View(values);
        }

        public ActionResult MakeActive(int id)
        {
            var value = context.Tickets.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("TicketList");
        }

        public ActionResult MakePassive(int id)
        {
            var value = context.Tickets.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("TicketList");
        }
    }
}