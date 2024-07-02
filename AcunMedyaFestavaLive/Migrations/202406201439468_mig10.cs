namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Schedules");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TimeRange = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ScheduleID);
            
        }
    }
}
