

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace CourseRegistration.Models
{
    public class Instructors
    {
        [Key]
        public int InstructorId { get; set; } 
        [Key]
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
    }
}
