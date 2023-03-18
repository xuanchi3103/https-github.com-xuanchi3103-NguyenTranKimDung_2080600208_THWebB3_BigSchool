using Microsoft.AspNet.Identity;
using NguyenTranKimDung_2080600208_THWebB3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenTranKimDung_2080600208_THWebB3.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController() {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var attendance = new Attendance
            {
                CourseId = courseId,
                AttendeeId = User.Identity.GetUserId()
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
