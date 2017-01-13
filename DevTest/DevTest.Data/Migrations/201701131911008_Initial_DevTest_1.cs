namespace Splats.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_DevTest_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campaign",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CampaignName = c.String(maxLength: 255),
                        Date = c.DateTime(nullable: false),
                        Clicks = c.Int(nullable: false),
                        Conversions = c.Int(nullable: false),
                        Impressions = c.Int(nullable: false),
                        AffiliateName = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Campaign");
        }
    }
}
