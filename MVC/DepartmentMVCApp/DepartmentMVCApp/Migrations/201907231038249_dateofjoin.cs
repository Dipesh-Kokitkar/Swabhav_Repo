namespace DepartmentMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateofjoin : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EMPLOYEE", "DateOfJoin", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EMPLOYEE", "DateOfJoin", c => c.Double(nullable: false));
        }
    }
}
