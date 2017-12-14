namespace Contoso2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStudentTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Students ( LastName, FirstMidName, EnrollmentDate) VALUES('Shukla', 'Devarsh', '2011-02-13 00:00:00')");
        }
        
        public override void Down()
        {
        }
    }
}
