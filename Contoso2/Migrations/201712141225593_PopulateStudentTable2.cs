namespace Contoso2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStudentTable2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Patel', 'Rushang', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Shukla', 'RipalKuamr', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Hall', 'matthew', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Eagan', 'Matt', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Patel', 'Raj', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Dave', 'Shivangini', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Adhyary', 'Maltiben', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Shukla', 'Ripalkumar', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Ramani', 'Nilesh', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Natarajan', 'Prakash', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Gurry', 'Tati', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Maknontami', 'Khalil', '2011-02-13 00:00:00')");
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Rai', 'Priya', '2011-02-13 00:00:00')");

        }
        
        public override void Down()
        {
        }
    }
}
