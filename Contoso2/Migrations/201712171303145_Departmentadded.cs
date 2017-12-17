namespace Contoso2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Departmentadded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Instructor_Id", "dbo.Instructors");
            DropIndex("dbo.Courses", new[] { "Instructor_Id" });
            CreateTable(
                "dbo.InstructorCourses",
                c => new
                    {
                        Instructor_Id = c.Int(nullable: false),
                        Course_CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Instructor_Id, t.Course_CourseID })
                .ForeignKey("dbo.Instructors", t => t.Instructor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseID, cascadeDelete: true)
                .Index(t => t.Instructor_Id)
                .Index(t => t.Course_CourseID);
            
            AddColumn("dbo.Courses", "DepartmentID", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "Instructor_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Instructor_Id", c => c.Int());
            DropForeignKey("dbo.InstructorCourses", "Course_CourseID", "dbo.Courses");
            DropForeignKey("dbo.InstructorCourses", "Instructor_Id", "dbo.Instructors");
            DropIndex("dbo.InstructorCourses", new[] { "Course_CourseID" });
            DropIndex("dbo.InstructorCourses", new[] { "Instructor_Id" });
            DropColumn("dbo.Courses", "DepartmentID");
            DropTable("dbo.InstructorCourses");
            CreateIndex("dbo.Courses", "Instructor_Id");
            AddForeignKey("dbo.Courses", "Instructor_Id", "dbo.Instructors", "Id");
        }
    }
}
