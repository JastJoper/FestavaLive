using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaFestavaLive.Areas.Member.Models;

namespace AcunMedyaFestavaLive.Areas.Member.Controllers
{
    [RouteArea("Member")]
    public class MyTicketController : Controller
    {

        Context context = new Context();  
        
        public ActionResult TicketList()
        {
            var values = context.Tickets.Where(x=>x.Status==true).ToList();
            return View(values);
        }
        public ActionResult MyTicketList()
        {
            int userId = (int)Session["UserId"];

            var tickets = (from ut in context.UserTickets
                           join t in context.Tickets on ut.TicketId equals t.TicketID
                           where ut.UserId == userId
                           select new UserTicketViewModel
                           {
                               TicketId = t.TicketID,
                               Title = t.Title,
                               Description = t.Description,
                               UserId = ut.UserId,
                               UserTicketId = ut.UserTicketID,
                               Price = t.Price,
                               Status = t.Status


                           }).Where(x => x.Status == true).ToList();

            return View(tickets);
        }

        public ActionResult PastMyTicketList()
        {
            int userId = (int)Session["UserId"];

            var tickets = (from ut in context.UserTickets
                           join t in context.Tickets on ut.TicketId equals t.TicketID
                           where ut.UserId == userId
                           select new UserTicketViewModel
                           {
                               TicketId = t.TicketID,
                               Title = t.Title,
                               Description = t.Description,
                               UserId = ut.UserId,
                               UserTicketId = ut.UserTicketID,
                               Price = t.Price,
                               Status = t.Status


                           }).Where(x => x.Status == false).ToList();

            return View(tickets);
        }


        public ActionResult MyTicketDelete(int id)
        {

            int userId = (int)Session["UserId"];


            var userTicket = context.UserTickets.FirstOrDefault(t => t.TicketId == id && t.UserId == userId);

            if (userTicket == null)
            {
                
                return HttpNotFound(); 
            }


            context.UserTickets.Remove(userTicket);
            context.SaveChanges();

            return RedirectToAction("MyTicketList");
        }


        public ActionResult TicketDetail(int id)
        {
            var values = context.Tickets.Find(id);
            return View(values);
            
        }

        [HttpGet]
        public ActionResult BuyTicket()
        {
          
            var ticketList = context.Tickets.Where(x=>x.Status==true).ToList();
            ViewBag.Tickets = new SelectList(ticketList, "TicketID", "Title"); 

            return View();
        }

        [HttpPost]
        public ActionResult BuyTicket(int TicketID)
        {
            if (Session["UserId"] == null)
            {
                
                return RedirectToAction("Auth", "SignIn");
            }

            int userId = (int)Session["UserId"];

           
            UserTicket userTicket = new UserTicket
            {
                UserId = userId,
                TicketId = TicketID
            };

            
            context.UserTickets.Add(userTicket);
            context.SaveChanges();

            
            return RedirectToAction("MyTicketList"); 
        }




    }
}