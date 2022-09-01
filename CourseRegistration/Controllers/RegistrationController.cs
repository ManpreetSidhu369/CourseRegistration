using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseRegistration.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly RegistrationContext _context;
        public RegistrationController()
        {

            _context = new RegistrationContext();
        }


        public IActionResult Courses()
        {

            var Courses = _context.courses.Include(c => c.students).ToList();
            return View(Courses);
        }
        public IActionResult AddCourse()
        {
            return View();
        }
        public IActionResult SaveCourse(Course course)
        {
            _context.courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Courses));
        }
        public IActionResult Students()
        {
            var Students = _context.students.ToList();
            return View(Students);
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        public IActionResult SaveStudent(Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(Students));
        }
        public IActionResult Instructor()
        {
            var Instructors = _context.instructors.ToList();

            return View(Instructors);
        }

        public IActionResult AddInstructor()
        {
            return View();
        }
        public IActionResult SaveInstructor(Instructors instructors)
        {
            _context.instructors.Add(instructors);
            _context.SaveChanges();
            return RedirectToAction(nameof(Instructor));
        }


    }
}
