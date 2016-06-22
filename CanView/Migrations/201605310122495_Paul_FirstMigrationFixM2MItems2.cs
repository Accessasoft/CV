namespace CanView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Paul_FirstMigrationFixM2MItems2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SbItem_Item_ItemSize",
                c => new
                    {
                        SbItem_Item_ItemSizeID = c.Int(nullable: false, identity: true),
                        SbItem_Item_SizePrice = c.String(),
                        SbItem_Item_SbItemID = c.Int(),
                        SbItem_Size_SbItemSizeID = c.Int(),
                    })
                .PrimaryKey(t => t.SbItem_Item_ItemSizeID)
                .ForeignKey("dbo.SbItems", t => t.SbItem_Item_SbItemID)
                .ForeignKey("dbo.SbItemSizes", t => t.SbItem_Size_SbItemSizeID)
                .Index(t => t.SbItem_Item_SbItemID)
                .Index(t => t.SbItem_Size_SbItemSizeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SbItem_Item_ItemSize", "SbItem_Size_SbItemSizeID", "dbo.SbItemSizes");
            DropForeignKey("dbo.SbItem_Item_ItemSize", "SbItem_Item_SbItemID", "dbo.SbItems");
            DropIndex("dbo.SbItem_Item_ItemSize", new[] { "SbItem_Size_SbItemSizeID" });
            DropIndex("dbo.SbItem_Item_ItemSize", new[] { "SbItem_Item_SbItemID" });
            DropTable("dbo.SbItem_Item_ItemSize");
        }
    }
}
