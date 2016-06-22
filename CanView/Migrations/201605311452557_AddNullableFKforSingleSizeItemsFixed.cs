namespace CanView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableFKforSingleSizeItemsFixed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SbItems", "SbItemTypeForNonMultySizeID", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SbItems", "SbItemTypeForNonMultySizeID", c => c.String());
        }
    }
}
