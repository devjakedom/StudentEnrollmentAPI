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
    public class CourseController : ApiController
    {
        private CourseService CreateCourseService()
        {
            //var userId = Guid.Parse(User.Identity.GetUserId());
            var courseService = new CourseService();
            return courseService;
        }

        public IHttpActionResult Get()
        {
            CourseService courseService = CreateCourseService();
            var courses = courseService.GetCourses();
            return Ok(courses);
        }

        public IHttpActionResult Post(CourseCreate course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCourseService();
            if (!service.CreateCourse(course))
                return InternalServerError();
            return Ok();
        }

        public IHttpActionResult Get(int iD)
        {
            CourseService courseService = CreateCourseService();
            var course = courseService.GetCourseById(iD);
            return Ok(course);
        }

        [Route("api/Course/InSession")]
        public IHttpActionResult GetCoursesInSession() //controller
        {
            CourseService courseService = CreateCourseService();
            var course = courseService.GetCoursesInSession();
            return Ok(course);
        }

        public IHttpActionResult Put(CourseEdit course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCourseService();
            if (!service.UpdateCourse(course))
                return InternalServerError();
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateCourseService();
            if (!service.DeleteCourse(id))
                return InternalServerError();
            return Ok();
        }
    }
}
