namespace Contoso2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class officeassignment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OfficeAssignments");
        }
    }
}
