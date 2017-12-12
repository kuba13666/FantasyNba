namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendingPages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "Title", c => c.String());
            AddColumn("dbo.Pages", "Slug", c => c.String());
            AddColumn("dbo.Pages", "Body", c => c.String());
            AddColumn("dbo.Pages", "Sorting", c => c.Int(nullable: false));
            AddColumn("dbo.Pages", "HasSidebar", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pages", "HasSidebar");
            DropColumn("dbo.Pages", "Sorting");
            DropColumn("dbo.Pages", "Body");
            DropColumn("dbo.Pages", "Slug");
            DropColumn("dbo.Pages", "Title");
        }
    }
}
