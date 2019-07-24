namespace DepartmentMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DEPARTMENT",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Dname = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EMPLOYEE",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        EName = c.String(),
                        Salary = c.Double(nullable: false),
                        Comission = c.Double(nullable: false),
                        DateOfJoin = c.Double(nullable: false),
                        Department_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DEPARTMENT", t => t.Department_ID)
                .Index(t => t.Department_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EMPLOYEE", "Department_ID", "dbo.DEPARTMENT");
            DropIndex("dbo.EMPLOYEE", new[] { "Department_ID" });
            DropTable("dbo.EMPLOYEE");
            DropTable("dbo.DEPARTMENT");
        }
    }
}
