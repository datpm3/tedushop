namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductCategories", "ParentID", c => c.Int());
            AlterColumn("dbo.ProductCategories", "Name", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.ProductCategories", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.ProductCategories", "Image", c => c.String(maxLength: 256));
            DropColumn("dbo.ProductCategories", "PartentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductCategories", "PartentID", c => c.Int());
            AlterColumn("dbo.ProductCategories", "Image", c => c.String());
            AlterColumn("dbo.ProductCategories", "Description", c => c.String());
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String(nullable: false));
            AlterColumn("dbo.ProductCategories", "Name", c => c.String(nullable: false));
            DropColumn("dbo.ProductCategories", "ParentID");
        }
    }
}
