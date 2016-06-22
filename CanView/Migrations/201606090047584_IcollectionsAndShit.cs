namespace CanView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IcollectionsAndShit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NightsOpens", "nightOpen_NightsID", "dbo.Nights");
            DropIndex("dbo.NightsOpens", new[] { "nightOpen_NightsID" });
            DropColumn("dbo.NightsOpens", "nightOpen_NightsID");
            DropTable("dbo.SnackBars");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SnackBars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.NightsOpens", "nightOpen_NightsID", c => c.Int());
            CreateIndex("dbo.NightsOpens", "nightOpen_NightsID");
            AddForeignKey("dbo.NightsOpens", "nightOpen_NightsID", "dbo.Nights", "NightsID");
        }
    }
}
