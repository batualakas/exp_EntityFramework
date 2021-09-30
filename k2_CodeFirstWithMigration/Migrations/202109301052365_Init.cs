namespace k2_CodeFirstWithMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        CourseNo = c.String(),
                        TeacherID = c.Int(nullable: false),
                        Course_CourseID = c.Int(),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Courses", t => t.Course_CourseID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.Course_CourseID);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.CourseID })
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        StudentSurname = c.String(),
                        StudentNo = c.Int(nullable: false),
                        Faculty = c.String(),
                        TeacherID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        FacultyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentID)
                .ForeignKey("dbo.Faculties", t => t.FacultyID, cascadeDelete: true)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyID = c.Int(nullable: false, identity: true),
                        FacultyName = c.String(),
                    })
                .PrimaryKey(t => t.FacultyID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Faculty = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            CreateTable(
                "dbo.DepartmenCourses",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DepartmentID, t.CourseID })
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.StudentCourse1",
                c => new
                    {
                        Student_StudentID = c.Int(nullable: false),
                        Course_CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_StudentID, t.Course_CourseID })
                .ForeignKey("dbo.Students", t => t.Student_StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseID, cascadeDelete: true)
                .Index(t => t.Student_StudentID)
                .Index(t => t.Course_CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DepartmenCourses", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.DepartmenCourses", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Courses", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.StudentCourses", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Students", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Departments", "FacultyID", "dbo.Faculties");
            DropForeignKey("dbo.StudentCourse1", "Course_CourseID", "dbo.Courses");
            DropForeignKey("dbo.StudentCourse1", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Courses", "Course_CourseID", "dbo.Courses");
            DropIndex("dbo.StudentCourse1", new[] { "Course_CourseID" });
            DropIndex("dbo.StudentCourse1", new[] { "Student_StudentID" });
            DropIndex("dbo.DepartmenCourses", new[] { "CourseID" });
            DropIndex("dbo.DepartmenCourses", new[] { "DepartmentID" });
            DropIndex("dbo.Departments", new[] { "FacultyID" });
            DropIndex("dbo.Students", new[] { "DepartmentID" });
            DropIndex("dbo.Students", new[] { "TeacherID" });
            DropIndex("dbo.StudentCourses", new[] { "CourseID" });
            DropIndex("dbo.StudentCourses", new[] { "StudentID" });
            DropIndex("dbo.Courses", new[] { "Course_CourseID" });
            DropIndex("dbo.Courses", new[] { "TeacherID" });
            DropTable("dbo.StudentCourse1");
            DropTable("dbo.DepartmenCourses");
            DropTable("dbo.Teachers");
            DropTable("dbo.Faculties");
            DropTable("dbo.Departments");
            DropTable("dbo.Students");
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Courses");
        }
    }
}
