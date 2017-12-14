namespace Contoso2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEnrollmentTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(1050, 2, 2)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(4022, 2, 3)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(1063, 3, 0)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(7888, 3,2)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(1050, 4, 3)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(4022, 5, 2)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(4022, 5, 4)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(1063, 7, 1)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(5510, 8, 2)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(5510, 5, 3)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(7888, 3, 4)");
            Sql("INSERT INTO Enrollments (CourseID,StudentID,Grade) VALUES(1050, 2, 5)");


        }
        
        public override void Down()
        {
        }
    }
}
