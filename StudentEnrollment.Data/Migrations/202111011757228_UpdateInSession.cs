namespace StudentEnrollment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateInSession : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "EndDate");
            DropColumn("dbo.Courses", "StartDate");
        }
    }
}
