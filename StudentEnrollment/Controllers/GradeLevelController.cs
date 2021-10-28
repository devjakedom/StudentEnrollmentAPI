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
    public class GradeLevelController : ApiController
    {
        private GradeLevelService CreateGradeLevelService()
        {
            var gradeLevelService = new GradeLevelService();
            return gradeLevelService;
        }
        public IHttpActionResult Get()
        {
            GradeLevelService gradeLevelService = CreateGradeLevelService();
            var gradeLevels = gradeLevelService.GetGradeLevels();
            return Ok(gradeLevels);
        }
        public IHttpActionResult Get(int GradeNumber)
        {
            GradeLevelService gradeLevelService = CreateGradeLevelService();
            var gradeLevel = gradeLevelService.GetGradeByNumber(GradeNumber);
            return Ok(gradeLevel);
        }
        public IHttpActionResult Post(GradeLevelCreate gradeLevel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateGradeLevelService();
            if (!service.CreateGradeLevel(gradeLevel))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Put(GradeLevelEdit gradeLevel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateGradeLevelService();
            if (!service.UpdateGradeLevel(gradeLevel))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Delete(int gradeId)
        {
            var service = CreateGradeLevelService();
            if (!service.DeleteGradeLevel(gradeId))
                return InternalServerError();
            return Ok();
        }
    }
}
