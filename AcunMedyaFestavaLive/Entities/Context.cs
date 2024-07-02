using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Entities
{
    public class Context : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<UserTicket> UserTickets { get; set; }
        public DbSet<Message> Messages { get; set; }


    }
}