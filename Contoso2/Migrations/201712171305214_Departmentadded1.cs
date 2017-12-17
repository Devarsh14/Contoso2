namespace Contoso2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Departmentadded1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "DepartmentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DepartmentID", c => c.Int(nullable: false));
        }
    }
}
