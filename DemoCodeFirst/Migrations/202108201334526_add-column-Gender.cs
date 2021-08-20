namespace DemoCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumnGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "bGender", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "bGender");
        }
    }
}
