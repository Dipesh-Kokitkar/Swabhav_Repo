namespace OneToManyEFApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LINEITEM",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Name = c.String(),
                        Unitprice = c.Double(nullable: false),
                        Order_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ORDER", t => t.Order_ID)
                .Index(t => t.Order_ID);
            
            CreateTable(
                "dbo.ORDER",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        CustomerName = c.String(),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LINEITEM", "Order_ID", "dbo.ORDER");
            DropIndex("dbo.LINEITEM", new[] { "Order_ID" });
            DropTable("dbo.ORDER");
            DropTable("dbo.LINEITEM");
        }
    }
}
