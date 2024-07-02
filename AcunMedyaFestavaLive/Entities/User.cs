using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string ImageUrl { get; set; }
        public string  UserName { get; set; }
        public string  Password { get; set; }
    }
}