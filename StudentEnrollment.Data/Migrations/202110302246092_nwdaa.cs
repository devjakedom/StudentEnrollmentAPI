namespace StudentEnrollment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nwdaa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "GradeId", "dbo.GradeLevels");
            DropIndex("dbo.Enrollments", new[] { "GradeId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Enrollments", "GradeId");
            AddForeignKey("dbo.Enrollments", "GradeId", "dbo.GradeLevels", "GradeId", cascadeDelete: true);
        }
    }
}
