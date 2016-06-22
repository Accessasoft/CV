namespace CanView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Paul_FirstMigrationFixM2MItems : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SbItemSizes", "SbItemSizePrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SbItemSizes", "SbItemSizePrice", c => c.String());
        }
    }
}
