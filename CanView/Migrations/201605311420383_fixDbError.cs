namespace CanView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDbError : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SbItems", "snackBarItemType_SbItemTypeID", c => c.Int());
            CreateIndex("dbo.SbItems", "snackBarItemType_SbItemTypeID");
            AddForeignKey("dbo.SbItems", "snackBarItemType_SbItemTypeID", "dbo.SbItemTypes", "SbItemTypeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SbItems", "snackBarItemType_SbItemTypeID", "dbo.SbItemTypes");
            DropIndex("dbo.SbItems", new[] { "snackBarItemType_SbItemTypeID" });
            DropColumn("dbo.SbItems", "snackBarItemType_SbItemTypeID");
        }
    }
}
