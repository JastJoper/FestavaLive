namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTickets",
                c => new
                    {
                        UserTicketID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TicketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserTicketID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTickets");
        }
    }
}
