using Microsoft.AspNet.Identity;
using StudentEnrollment.Data;
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
    public class EnrollmentController : ApiController
    {
        
        
            private EnrollmentService CreateEnrollmentService()
            {
                var OwnerId = Guid.Parse(User.Identity.GetUserId());
                var EnrollmentService = new EnrollmentService(OwnerId);
                return EnrollmentService;
            }
            public IHttpActionResult Get()
            {
            EnrollmentService EnrollmentService = CreateEnrollmentService();
                var Enrollment = EnrollmentService.GetEnrollmentList();
                return Ok(Enrollment);
            }
            public IHttpActionResult Post(CreateEnrollment enrollment)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var service = CreateEnrollmentService();

                if (!service.CreateEnrollment(enrollment))
                    return InternalServerError();

                return Ok();
            }

            public IHttpActionResult Put(EnrollmentEdit enrollment)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var service = CreateEnrollmentService();

                if (!service.EditEnrollment(enrollment))
                    return InternalServerError();

                return Ok();
            }
            public IHttpActionResult Delete(int EnrollmentId)
            {
                var service = CreateEnrollmentService();

                if (!service.DeleteEnrollment(EnrollmentId))
                    return InternalServerError();

                return Ok();
            }
        }
    }

