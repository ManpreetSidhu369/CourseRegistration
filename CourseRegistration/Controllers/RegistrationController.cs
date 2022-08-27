using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistration.Controllers
{

    public class RegistrationController : Controller
    {
        private List<Course> courses;
        private List<Student> students;
        private List<Instructors> instructors;
        public RegistrationController()
        {
            courses = new List<Course>
            {
                new Course
                {
                    CourseId = 1,
                    CourseNumber=101,
                    CourseName = "Asp.net",
                    Description = "Asp.Net Course",
                    students = new List<Student>
                    {
                        new Student
                        {
                            StudentId = 111,
                            FirstName = "Manpreet",
                            LastName = "Sidhu",
                            Email = "abc.gmail.com",
                            PhoneNo = 123456789
                        },
                        new Student
                        {
                            StudentId = 112,
                            FirstName = "Jaggy",
                            LastName = "Dhaliwal",
                            Email = "def.gmail.com",
                            PhoneNo = 1011121314

                        },
                         new Student
                        {
                            StudentId = 113,
                            FirstName = "Raman",
                            LastName = "Kehal",
                            Email = "abc.gmail.com",
                            PhoneNo = 123456789
                        },
                        new Student
                        {
                            StudentId = 114,
                            FirstName = "Jaspinder",
                            LastName = "Sidhu",
                            Email = "def.gmail.com",
                            PhoneNo = 1011121314

                        }


                    }

                },
                new Course
                {
                    CourseId = 2,
                    CourseNumber=102,
                    CourseName = "C# Basis",
                    Description = "C# Basis Course",
                    students = new List<Student>
                    {
                        new Student
                        {
                            StudentId = 111,
                            FirstName = "Manpreet",
                            LastName = "Sidhu",
                            Email = "abc.gmail.com",
                            PhoneNo = 123456789
                        },
                        new Student
                        {
                            StudentId = 115,
                            FirstName = "Pretty",
                            LastName = "Grewal",
                            Email = "def.gmail.com",
                            PhoneNo = 1011121314

                        }
                    }
                }
            };
            students = new List<Student>
            {
                new Student
                {
                    StudentId = 111,
                    FirstName = "Manpreet",
                    LastName = "Sidhu",
                    Email = "abc.gmail.com",
                    PhoneNo = 123456789
                },
                new Student
                {
                    StudentId = 112,
                    FirstName = "Jaggy",
                    LastName = "Dhaliwal",
                    Email = "def.gmail.com",
                    PhoneNo = 1011121314

                },
                new Student
                {
                    StudentId = 113,
                    FirstName = "Raman",
                    LastName = "Kehal",
                    Email = "abc.gmail.com",
                    PhoneNo = 123456789
                },
                new Student
                {
                    StudentId = 114,
                    FirstName = "Jaspinder",
                    LastName = "Sidhu",
                    Email = "def.gmail.com",
                    PhoneNo = 1011121314


                },
                new Student
                        {
                            StudentId = 115,
                            FirstName = "Pretty",
                            LastName = "Grewal",
                            Email = "def.gmail.com",
                            PhoneNo = 1011121314

                        }
            };
            instructors = new List<Instructors>
            {
                new Instructors
                {
                    InstructorId=101,
                    FirstName ="Aman",
                    LastName="Rai",
                    Email="pop@gmail.com",
                    Course ="Asp.net"

                },
                 new Instructors
                {
                    InstructorId=102,
                    FirstName ="Bobby",
                    LastName="Khera",
                    Email="Bobs@gmail.com",
                    Course ="C# Basis"

                }
            };
            
        } 


        public IActionResult Courses()
        {
            return View(courses);
        }
        public IActionResult Students()
        {
            return View(students);
        }
        public IActionResult Instructor()
        {
            return View(instructors);
        }

    }
}



