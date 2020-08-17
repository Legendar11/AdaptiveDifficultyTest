namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Coef", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Coef");
        }
    }
}
