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
        private readonly Guid _userId;
        public StudentService(Guid userId)
        {
            _userId = userId;
        }

        public bool StudentCreate(CreateStudent model)
        {
            var entity = new Student()
            {
                StudentId = _userId,
                StudentName = model.StudentName,
                StudentGradeLevel = model.StudentGradeLevel
            };
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Students.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<StudentList> GetStudents()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Students.Where(e => e.StudentId == _userId).Select(e => new StudentList
                {
                    StudentId = e.StudentId,
                    StudentName = e.StudentName,
                    StudentGradeLevel = e.StudentGradeLevel
                });

                return query.ToArray();
            }
        }

        public DetailsStudent GetStudentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Students.Single(e => e.StudentId == _userId);
                return new DetailsStudent
                {
                    StudentId = entity.StudentId,
                    StudentName = entity.StudentName,
                    StudentGradeLevel = entity.StudentGradeLevel
                };
            }
        }

        public bool StudentEdit(EditStudent model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Students.Single(e => e.StudentName == model.StudentName);
                entity.StudentName = model.StudentName;
                entity.StudentGradeLevel = model.StudentGradeLevel;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
