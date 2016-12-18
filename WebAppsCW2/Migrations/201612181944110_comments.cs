namespace WebAppsCW2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comments : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "CommentBody", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CommentBody", c => c.String());
        }
    }
}
