namespace Contoso2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmetnFinal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        InstructorID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Instructors", t => t.InstructorID)
                .Index(t => t.InstructorID);
            
            AddColumn("dbo.Courses", "Department_ID", c => c.Int());
            CreateIndex("dbo.Courses", "Department_ID");
            AddForeignKey("dbo.Courses", "Department_ID", "dbo.Departments", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Department_ID", "dbo.Departments");
            DropForeignKey("dbo.Departments", "InstructorID", "dbo.Instructors");
            DropIndex("dbo.Departments", new[] { "InstructorID" });
            DropIndex("dbo.Courses", new[] { "Department_ID" });
            DropColumn("dbo.Courses", "Department_ID");
            DropTable("dbo.Departments");
        }
    }
}
