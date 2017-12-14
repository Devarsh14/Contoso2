namespace Contoso2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses ( CourseID,Title,Credits) VALUES(1050, 'Chemistry', 4)");
            Sql("INSERT INTO Courses ( CourseID,Title,Credits) VALUES(4022, 'Compute Science', 5)");
            Sql("INSERT INTO Courses ( CourseID,Title,Credits) VALUES(4041, 'Calculus', 4)");
            Sql("INSERT INTO Courses ( CourseID,Title,Credits) VALUES(1063, 'Mathematics', 5)");
            Sql("INSERT INTO Courses ( CourseID,Title,Credits) VALUES(2056, 'Biology', 3)");
            Sql("INSERT INTO Courses ( CourseID,Title,Credits) VALUES(5845, 'Trignomatery', 4)");
            Sql("INSERT INTO Courses ( CourseID,Title,Credits) VALUES(7888, 'Composition', 4)");
            Sql("INSERT INTO Courses ( CourseID,Title,Credits) VALUES(2089, 'Literature', 4)");
            Sql("INSERT INTO Courses ( CourseID,Title,Credits) VALUES(5510, 'Drama', 3)");

        }
        
        public override void Down()
        {
        }
    }
}
