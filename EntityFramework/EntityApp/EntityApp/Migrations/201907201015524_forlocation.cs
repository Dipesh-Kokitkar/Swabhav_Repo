namespace EntityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forlocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.STUDENT", "Loaction", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.STUDENT", "Loaction");
        }
    }
}
