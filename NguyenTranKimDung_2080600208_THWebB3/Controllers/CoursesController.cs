using Microsoft.AspNet.Identity;
using NguyenTranKimDung_2080600208_THWebB3.Models;
using NguyenTranKimDung_2080600208_THWebB3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenTranKimDung_2080600208_THWebB3.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            var course = new Course
            {
                LecturerID= User.Identity.GetUserId(),
                DateTime= viewModel.GetDateTime(),
                CategoryID= viewModel.Category,
                Place= viewModel.Place,
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}