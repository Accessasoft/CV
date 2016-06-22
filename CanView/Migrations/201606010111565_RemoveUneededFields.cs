namespace CanView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUneededFields : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SbItems", "SbItemTypeForNonMultySizeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SbItems", "SbItemTypeForNonMultySizeID", c => c.Int());
        }
    }
}
