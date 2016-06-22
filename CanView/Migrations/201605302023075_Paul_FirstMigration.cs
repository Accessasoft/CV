namespace CanView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Paul_FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketPricings",
                c => new
                    {
                        TicketPricingID = c.Int(nullable: false, identity: true),
                        TicketPricingType = c.String(),
                        TicketPriceDesc = c.String(),
                        TicketPriceAmount = c.String(),
                    })
                .PrimaryKey(t => t.TicketPricingID);
            
            DropTable("dbo.Pricings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Pricings",
                c => new
                    {
                        TicketPirceingID = c.Int(nullable: false, identity: true),
                        TicketPricingType = c.String(),
                        TicketPriceDesc = c.String(),
                        TicketPriceAmount = c.String(),
                    })
                .PrimaryKey(t => t.TicketPirceingID);
            
            DropTable("dbo.TicketPricings");
        }
    }
}
