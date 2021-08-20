namespace DemoCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        sId = c.String(nullable: false, maxLength: 10),
                        sName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.sId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        sId = c.String(nullable: false, maxLength: 10),
                        sName = c.String(maxLength: 100),
                        sIdClass = c.String(maxLength: 10),
                        sAddress = c.String(maxLength: 255),
                        dBirthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.sId)
                .ForeignKey("dbo.Classes", t => t.sIdClass)
                .Index(t => t.sIdClass);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        sIdStudent = c.String(nullable: false, maxLength: 128),
                        sIdSubject = c.String(nullable: false, maxLength: 128),
                        dScore = c.Double(nullable: false),
                        Student_sId = c.String(maxLength: 10),
                        Subject_sId = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => new { t.sIdStudent, t.sIdSubject })
                .ForeignKey("dbo.Students", t => t.Student_sId)
                .ForeignKey("dbo.Subjects", t => t.Subject_sId)
                .Index(t => t.Student_sId)
                .Index(t => t.Subject_sId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        sId = c.String(nullable: false, maxLength: 10),
                        sName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.sId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scores", "Subject_sId", "dbo.Subjects");
            DropForeignKey("dbo.Scores", "Student_sId", "dbo.Students");
            DropForeignKey("dbo.Students", "sIdClass", "dbo.Classes");
            DropIndex("dbo.Scores", new[] { "Subject_sId" });
            DropIndex("dbo.Scores", new[] { "Student_sId" });
            DropIndex("dbo.Students", new[] { "sIdClass" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Scores");
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
