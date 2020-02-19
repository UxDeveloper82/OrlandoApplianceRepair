namespace ApplianceRepair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMyBlogClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyBlogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ImgUrl = c.String(),
                        SomeDetails = c.String(),
                        MoreDetails = c.String(),
                        DatePost = c.DateTime(nullable: false),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyBlogs");
        }
    }
}
