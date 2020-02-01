namespace ApplianceRepair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotaions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MyMessages", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.MyMessages", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.MyMessages", "Message", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MyMessages", "Message", c => c.String());
            AlterColumn("dbo.MyMessages", "Email", c => c.String());
            AlterColumn("dbo.MyMessages", "Name", c => c.String());
        }
    }
}
