namespace OneToManyEFApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PRODUCT",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ProductName = c.String(),
                        Price = c.Double(nullable: false),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.LINEITEM", "Product_ID", c => c.Guid());
            CreateIndex("dbo.LINEITEM", "Product_ID");
            AddForeignKey("dbo.LINEITEM", "Product_ID", "dbo.PRODUCT", "ID");
            DropColumn("dbo.LINEITEM", "Unitprice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LINEITEM", "Unitprice", c => c.Double(nullable: false));
            DropForeignKey("dbo.LINEITEM", "Product_ID", "dbo.PRODUCT");
            DropIndex("dbo.LINEITEM", new[] { "Product_ID" });
            DropColumn("dbo.LINEITEM", "Product_ID");
            DropTable("dbo.PRODUCT");
        }
    }
}
