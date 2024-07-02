using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Areas.Member.Models
{
    public class UserTicketViewModel
    {
        public int TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public int UserTicketId { get; set; }
        public bool Status { get; set; }

    }
}