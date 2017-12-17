namespace Contoso2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstructorAdded3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OfficeAssignments", "InstructorID", c => c.Int(nullable: false));
            CreateIndex("dbo.OfficeAssignments", "InstructorID");
            AddForeignKey("dbo.OfficeAssignments", "InstructorID", "dbo.Instructors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "InstructorID", "dbo.Instructors");
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorID" });
            DropColumn("dbo.OfficeAssignments", "InstructorID");
        }
    }
}
