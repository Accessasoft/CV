namespace CanView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Paul_FirstMigrationFixDatatypeError : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SbItemTypes", "SbItemTypeDesc", c => c.String());
            AlterColumn("dbo.SbItemTypes", "SbItemTypeName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SbItemTypes", "SbItemTypeName", c => c.Int(nullable: false));
            AlterColumn("dbo.SbItemTypes", "SbItemTypeDesc", c => c.Int(nullable: false));
        }
    }
}
