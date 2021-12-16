namespace MyMVCProject.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.Int(nullable: false),
                        ContactPerson = c.String(),
                        Supplier_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID)
                .Index(t => t.Supplier_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suppliers", "Supplier_ID", "dbo.Suppliers");
            DropIndex("dbo.Suppliers", new[] { "Supplier_ID" });
            DropTable("dbo.Suppliers");
        }
    }
}
