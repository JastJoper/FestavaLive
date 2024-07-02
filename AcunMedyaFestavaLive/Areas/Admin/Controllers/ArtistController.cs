using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
{
    public class ArtistController : Controller
    {
        Context context = new Context();
        public ActionResult ArtistList()
        {
            var values = context.Artists.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateArtist()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateArtist(Artist artist)
        {
            context.Artists.Add(artist);
            context.SaveChanges();
            return RedirectToAction("ArtistList");
        }
        public ActionResult DeleteArtist(int id)
        {
            var values = context.Artists.Find(id);
            context.Artists.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Artistlist");
        }
        [HttpGet]
        public ActionResult UpdateArtist(int id)
        {
            var values = context.Artists.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateArtist(Artist artist)
        {
            var values = context.Artists.Find(artist.ArtistID);
            values.NameSurname = artist.NameSurname;
            values.ImageUrl = artist.ImageUrl;
            values.Date = artist.Date;
            values.Description = artist.Description;
            values.Description2 = artist.Description2;
            context.SaveChanges();
            return RedirectToAction("ArtistList");
        }


    }
}