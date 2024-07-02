using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Entities
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ImageUrl { get; set; }
        public string NameSurname { get; set; }
        public DateTime  Date{ get; set; }
        public string  Description{ get; set; }
        public string  Description2{ get; set; }
        
    }
}