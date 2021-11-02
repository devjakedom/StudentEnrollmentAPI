namespace StudentEnrollment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedGradeIdtoEnrollment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "GradeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enrollments", "GradeId");
            AddForeignKey("dbo.Enrollments", "GradeId", "dbo.GradeLevels", "GradeId", cascadeDelete: false);
            DropColumn("dbo.Enrollments", "StudentGrade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrollments", "StudentGrade", c => c.Int(nullable: false));
            DropForeignKey("dbo.Enrollments", "GradeId", "dbo.GradeLevels");
            DropIndex("dbo.Enrollments", new[] { "GradeId" });
            DropColumn("dbo.Enrollments", "GradeId");
        }
    }
}
