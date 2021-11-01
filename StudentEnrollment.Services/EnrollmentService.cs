using StudentEnrollment.Data;
using StudentEnrollment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Services
{
    public class EnrollmentService
    {
        /*private readonly Guid _userId;
        public EnrollmentService(Guid userId)
        {
            _userId = userId;
        }
        */
        public bool CreateEnrollment(CreateEnrollment model)
        {
            var entity =
                new Enrollment()
                {
                    //OwnerId = _userId,
                    StudentId = model.StudentId,
                    GradeId = model.GradeId,
                    CourseId = model.CourseId
                };
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Courses
                 .Single(e=> e.CourseId == entity.CourseId);

                if (!query.InSession)
                {
                    return false;
                }

                ctx.Enrollment
                   .Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }


        public IEnumerable<EnrollmentListItem> GetEnrollmentList()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Enrollment
                    // .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new EnrollmentListItem
                        {
                            EnrollmentId = e.EnrollmentId,
                            StudentId = e.StudentId,
                            GradeId = e.GradeId,
                            CourseId = e.CourseId,

                        }
                        );
                return query.ToArray();

            }
        }

        /*public EnrollmentDetails GetPersonById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Enrollment
                    .Single(e => e.EnrollmentId == id && e.OwnerId == _userId);
                return
                   new PersonDetails
                    {
                        PersonId = entity.PersonId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        State = entity.State,
                      StreetAddress = entity.StreetAddress,
                       City = entity.City
                    };
            }
        }*/
        public bool EditEnrollment(EnrollmentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Enrollment
                    .Single(e => e.EnrollmentId == model.EnrollmentId);

                entity.EnrollmentId = model.EnrollmentId;
                entity.CourseId = model.CourseId;
                entity.StudentId = model.StudentId;
                entity.GradeId = model.GradeId;


                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteEnrollment(int EnrollmentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Enrollment
                    .Single(e => e.EnrollmentId == EnrollmentId /*&& e.OwnerId == _userId*/);

                ctx.Enrollment.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
