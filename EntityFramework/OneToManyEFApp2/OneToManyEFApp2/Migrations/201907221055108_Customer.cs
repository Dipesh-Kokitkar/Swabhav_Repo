namespace OneToManyEFApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CUSTOMER",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                        PhoneNumber = c.Double(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.ORDER", "Customer_ID", c => c.Guid());
            CreateIndex("dbo.ORDER", "Customer_ID");
            AddForeignKey("dbo.ORDER", "Customer_ID", "dbo.CUSTOMER", "ID");
            DropColumn("dbo.ORDER", "CustomerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ORDER", "CustomerName", c => c.String());
            DropForeignKey("dbo.ORDER", "Customer_ID", "dbo.CUSTOMER");
            DropIndex("dbo.ORDER", new[] { "Customer_ID" });
            DropColumn("dbo.ORDER", "Customer_ID");
            DropTable("dbo.CUSTOMER");
        }
    }
}
