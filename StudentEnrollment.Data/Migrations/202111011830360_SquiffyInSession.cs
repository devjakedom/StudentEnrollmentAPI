namespace StudentEnrollment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SquiffyInSession : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "InSession", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "InSession");
        }
    }
}
