using StudentEnrollment.Data;
using StudentEnrollment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Services
{
    public class GradeLevelService
    {
        public bool CreateGradeLevel(GradeLevelCreate model)
        {
            var entity = new GradeLevel()
            {
                //GradeId = model.GradeId,
                GradeNumber = model.GradeNumber,
                GradeName = model.GradeName,
            };
            using(var ctx = new ApplicationDbContext())
            {
                ctx.GradeLevel.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<GradeLevelList> GetGradeLevels()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.GradeLevel.Select
                    (e => new GradeLevelList
                        {
                            
                            GradeNumber = e.GradeNumber,
                            GradeName = e.GradeName,
                            StudentList = e.StudentList,
                            GradeId = e.GradeId
                        }
                    );
                return query.ToArray();
            }
        }
        public GradeLevelDetail GetGradeByNumber(int gradeNumber)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.GradeLevel.Single(e => e.GradeNumber == gradeNumber);
                return new GradeLevelDetail
                {
                    GradeNumber = entity.GradeNumber,
                    GradeName = entity.GradeName,
                    StudentList = entity.StudentList
                };
            }
        }
        public bool UpdateGradeLevel(GradeLevelEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .GradeLevel
                    .Single(e => e.GradeId == model.GradeId);
                entity.GradeName = model.GradeName;
                entity.GradeNumber = model.GradeNumber;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteGradeLevel(int gradeNumber)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.GradeLevel.Single(e => e.GradeNumber == gradeNumber);
                ctx.GradeLevel.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
