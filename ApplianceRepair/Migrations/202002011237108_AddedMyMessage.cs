namespace ApplianceRepair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMyMessage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyMessages");
        }
    }
}
