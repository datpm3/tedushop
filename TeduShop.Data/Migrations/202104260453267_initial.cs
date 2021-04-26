namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "MetaDescription", c => c.String(maxLength: 500));
            AddColumn("dbo.ProductCategories", "MetaDescription", c => c.String(maxLength: 500));
            AddColumn("dbo.Pages", "MetaDescription", c => c.String(maxLength: 500));
            AddColumn("dbo.PostCategories", "ParentID", c => c.Int());
            AddColumn("dbo.PostCategories", "MetaDescription", c => c.String(maxLength: 500));
            AddColumn("dbo.Posts", "MetaDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.ProductCategories", "Description", c => c.String());
            AlterColumn("dbo.PostCategories", "Name", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.PostCategories", "Alias", c => c.String(nullable: false, maxLength: 256, unicode: false));
            AlterColumn("dbo.PostCategories", "Image", c => c.String(maxLength: 256));
            DropColumn("dbo.Products", "DisplayOrder");
            DropColumn("dbo.Pages", "Description");
            DropColumn("dbo.Pages", "DisplayOrder");
            DropColumn("dbo.PostCategories", "PartentID");
            DropColumn("dbo.Posts", "DisplayOrder");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "DisplayOrder", c => c.Int());
            AddColumn("dbo.PostCategories", "PartentID", c => c.Int());
            AddColumn("dbo.Pages", "DisplayOrder", c => c.Int());
            AddColumn("dbo.Pages", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.Products", "DisplayOrder", c => c.Int());
            AlterColumn("dbo.PostCategories", "Image", c => c.String());
            AlterColumn("dbo.PostCategories", "Alias", c => c.String(nullable: false));
            AlterColumn("dbo.PostCategories", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ProductCategories", "Description", c => c.String(maxLength: 500));
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.PostCategories", "MetaDescription");
            DropColumn("dbo.PostCategories", "ParentID");
            DropColumn("dbo.Pages", "MetaDescription");
            DropColumn("dbo.ProductCategories", "MetaDescription");
            DropColumn("dbo.Products", "MetaDescription");
        }
    }
}
