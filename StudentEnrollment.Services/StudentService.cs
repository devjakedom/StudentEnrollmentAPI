using StudentEnrollment.Data;
using StudentEnrollment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Services
{
    public class StudentService
    {
       // private readonly Guid _userId;
       // public StudentService(Guid userId)
        //{
          //  _userId = userId;
        //}

        public bool StudentCreate(CreateStudent model)
        {
            var entity = new Student()
            {
                StudentId = model.StudentId,
                StudentName = model.StudentName,
                GradeId = model.GradeId
            };
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Student.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<StudentList> GetStudents()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Student
                   // .Where(e => e.StudentId == _userId)
                    .Select(e => new StudentList
                {
                    StudentId = e.StudentId,
                    StudentName = e.StudentName,
                    GradeId = e.GradeId
                    });

                return query.ToArray();
            }
        }

        public DetailsStudent GetStudentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Student.Single(e => e.StudentId == id);
                return new DetailsStudent
                {
                    StudentId = entity.StudentId,
                    StudentName = entity.StudentName,
                    GradeId = entity.GradeId
                };
            }
        }

        public bool StudentEdit(EditStudent model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Student.Single(e => e.StudentName == model.StudentName);
                entity.StudentName = model.StudentName;
                entity.GradeId = model.GradeId;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteStudent(int Id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Student
                    .Single(e => e.StudentId == Id /*&& e.OwnerId == _userId*/);

                ctx.Student.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
