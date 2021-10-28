using StudentEnrollment.Data;
using StudentEnrollment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Services
{
    public class CourseService
    {
        //private readonly Guid _userId;
        //public CourseService(Guid userId)
        //{ _userId = userId; }


        public bool CreateCourse(CourseCreate model)
        {
            var entity =
                new Course()
                {
                    CourseDescription = model.Description,
                    CourseName = model.CourseName,
                    GradeId = model.GradeId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Courses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CourseList> GetCourses()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Courses
                    /* .Where(e => e.OwnerId == _userId)*/
                    .Select(
                        e =>
                        new CourseList
                        {
                            CourseId = e.CourseId,
                            CourseName = e.CourseName
                        }
                        );
                return query.ToArray();

            }
        }

        public CourseDetail GetCourseById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Courses
                    .Single(e => e.CourseId == id /* && e.OwnerId == _userId*/);
                return
                    new CourseDetail
                    {
                        CourseId = entity.CourseId,
                        CourseName = entity.CourseName,
                        Description = entity.CourseDescription

                    };
            }
        }

        public bool UpdateCourse(CourseEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Courses
                    .Single(e => e.CourseId == model.CourseId /*&& e.OwnerId == _userId*/);
                entity.CourseName = model.CourseName;
                entity.CourseDescription = model.CourseDescription;
                entity.GradeId = model.GradeId;

                return ctx.SaveChanges() == 1;

            }
        }

        public bool DeleteCourse(int courseId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                      ctx
                      .Courses
                      .Single(e => e.CourseId == courseId /*&& e.OwnerId == _userId*/);
                ctx.Courses.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
