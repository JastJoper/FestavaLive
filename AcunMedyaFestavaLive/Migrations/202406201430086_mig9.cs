namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.Schedules");
        }
    }
}
