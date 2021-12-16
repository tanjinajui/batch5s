namespace MyMVCProject.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Suppliers", "Supplier_ID", "dbo.Suppliers");
            DropIndex("dbo.Suppliers", new[] { "Supplier_ID" });
            AlterColumn("dbo.Suppliers", "Code", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Suppliers", "Supplier_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Suppliers", "Supplier_ID", c => c.Int());
            AlterColumn("dbo.Suppliers", "Code", c => c.String());
            CreateIndex("dbo.Suppliers", "Supplier_ID");
            AddForeignKey("dbo.Suppliers", "Supplier_ID", "dbo.Suppliers", "ID");
        }
    }
}
