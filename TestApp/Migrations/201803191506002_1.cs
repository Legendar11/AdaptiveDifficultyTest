namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        AnswerTitle = c.String(),
                        IsTrue = c.Boolean(nullable: false),
                        QuestionId = c.Guid(nullable: false),
                        Category_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.QuestionId)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        QuesionTitle = c.String(),
                        Mark = c.Int(nullable: false),
                        isTren = c.Boolean(nullable: false),
                        Category_Id = c.Guid(),
                        TheoryOfQuestion_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Theories", t => t.TheoryOfQuestion_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.TheoryOfQuestion_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        NextCount = c.Int(nullable: false),
                        PrevCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Theories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        SubjectTitle = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategorySets",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Type = c.String(),
                        Current_Id = c.Guid(),
                        Other_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Current_Id)
                .ForeignKey("dbo.Categories", t => t.Other_Id)
                .Index(t => t.Current_Id)
                .Index(t => t.Other_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategorySets", "Other_Id", "dbo.Categories");
            DropForeignKey("dbo.CategorySets", "Current_Id", "dbo.Categories");
            DropForeignKey("dbo.Questions", "TheoryOfQuestion_Id", "dbo.Theories");
            DropForeignKey("dbo.Questions", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Answers", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropIndex("dbo.CategorySets", new[] { "Other_Id" });
            DropIndex("dbo.CategorySets", new[] { "Current_Id" });
            DropIndex("dbo.Questions", new[] { "TheoryOfQuestion_Id" });
            DropIndex("dbo.Questions", new[] { "Category_Id" });
            DropIndex("dbo.Answers", new[] { "Category_Id" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.CategorySets");
            DropTable("dbo.Theories");
            DropTable("dbo.Categories");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
