using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Entities
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int ArtistId { get; set; }
        public bool Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TicketProperty1 { get; set; }
        public string TicketProperty2 { get; set; }
        public string TicketProperty3 { get; set; }
        public string TicketProperty4 { get; set; }
        public string TicketProperty5 { get; set; }
        public string TicketProperty6 { get; set; }
        public decimal Price { get; set; }
		public string ImageUrl { get; set; } 


	}
}