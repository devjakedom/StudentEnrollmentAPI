using Microsoft.AspNet.Identity;
using StudentEnrollment.Models;
using StudentEnrollment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentEnrollment.Controllers
{
    [Authorize]
    public class StudentController : ApiController
    {
        private StudentService CreateStudentService()
        {
            //var studentId = Guid.Parse(User.Identity.GetUserId());
            var studentService = new StudentService();
            return studentService;
        }

        public IHttpActionResult Get()
        {
            StudentService studentService = CreateStudentService();
            var students = studentService.GetStudents();
            return Ok(students);
        }

        public IHttpActionResult Post(Models.CreateStudent student)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = CreateStudentService();

            if(!service.StudentCreate(student))
            {
                return InternalServerError();
            }

            return Ok();
        }

        public IHttpActionResult Put(EditStudent student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = CreateStudentService();

            if (!service.StudentEdit(student))
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}
