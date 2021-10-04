namespace k2_CodeFirstWithMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TCPropAddedToStudent : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentCourse1", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentCourse1", "Course_CourseID", "dbo.Courses");
            DropIndex("dbo.StudentCourse1", new[] { "Student_StudentID" });
            DropIndex("dbo.StudentCourse1", new[] { "Course_CourseID" });
            AddColumn("dbo.Courses", "Student_StudentID", c => c.Int());
            AddColumn("dbo.Students", "TCKN", c => c.String());
            CreateIndex("dbo.Courses", "Student_StudentID");
            AddForeignKey("dbo.Courses", "Student_StudentID", "dbo.Students", "StudentID");
            DropTable("dbo.StudentCourse1");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentCourse1",
                c => new
                    {
                        Student_StudentID = c.Int(nullable: false),
                        Course_CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_StudentID, t.Course_CourseID });
            
            DropForeignKey("dbo.Courses", "Student_StudentID", "dbo.Students");
            DropIndex("dbo.Courses", new[] { "Student_StudentID" });
            DropColumn("dbo.Students", "TCKN");
            DropColumn("dbo.Courses", "Student_StudentID");
            CreateIndex("dbo.StudentCourse1", "Course_CourseID");
            CreateIndex("dbo.StudentCourse1", "Student_StudentID");
            AddForeignKey("dbo.StudentCourse1", "Course_CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourse1", "Student_StudentID", "dbo.Students", "StudentID", cascadeDelete: true);
        }
    }
}
