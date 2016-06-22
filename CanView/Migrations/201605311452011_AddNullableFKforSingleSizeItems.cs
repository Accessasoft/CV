namespace CanView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableFKforSingleSizeItems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SbItems", "SbItemTypeForNonMultySizeID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SbItems", "SbItemTypeForNonMultySizeID");
        }
    }
}
