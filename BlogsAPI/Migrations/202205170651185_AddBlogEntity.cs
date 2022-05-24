namespace BlogsAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        BlogContent = c.String(nullable: false),
                        BlogDateTime = c.DateTime(nullable: false),
                        fk_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlogID)
                .ForeignKey("dbo.Users", t => t.fk_UserID, cascadeDelete: true)
                .Index(t => t.fk_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "fk_UserID", "dbo.Users");
            DropIndex("dbo.Blogs", new[] { "fk_UserID" });
            DropTable("dbo.Blogs");
        }
    }
}
