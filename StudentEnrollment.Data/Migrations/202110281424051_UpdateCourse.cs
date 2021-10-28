namespace StudentEnrollment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCourse : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "GradeNumber", newName: "GradeId");
            RenameIndex(table: "dbo.Courses", name: "IX_GradeNumber", newName: "IX_GradeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_GradeId", newName: "IX_GradeNumber");
            RenameColumn(table: "dbo.Courses", name: "GradeId", newName: "GradeNumber");
        }
    }
}
