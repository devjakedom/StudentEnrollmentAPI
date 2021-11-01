namespace StudentEnrollment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateThingsForStuff : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Enrollments", "GradeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrollments", "GradeId", c => c.Int(nullable: false));
        }
    }
}
