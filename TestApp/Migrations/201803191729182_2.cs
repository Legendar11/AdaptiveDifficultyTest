namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            //DropIndex("dbo.Answers", new[] { "Category_Id" });
            //DropColumn("dbo.Answers", "Category_Id");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Answers", "Category_Id", c => c.Guid());
            //CreateIndex("dbo.Answers", "Category_Id");
        }
    }
}
