namespace AcunMedyaFestavaLive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        DateInterval = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
            CreateTable(
                "dbo.OperationClaims",
                c => new
                    {
                        OperationClaimID = c.Int(nullable: false, identity: true),
                        ClaimName = c.String(),
                    })
                .PrimaryKey(t => t.OperationClaimID);
            
            CreateTable(
                "dbo.UserOperationClaims",
                c => new
                    {
                        UserOperationClaimID = c.Int(nullable: false, identity: true),
                        OperationClaimId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserOperationClaimID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            AddColumn("dbo.Tickets", "ArtistId", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "UserId");
            DropColumn("dbo.Tickets", "ArtistId");
            DropTable("dbo.Users");
            DropTable("dbo.UserOperationClaims");
            DropTable("dbo.OperationClaims");
            DropTable("dbo.Features");
        }
    }
}
