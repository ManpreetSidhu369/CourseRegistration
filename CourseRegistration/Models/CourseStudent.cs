using System.ComponentModel.DataAnnotations;

namespace CourseRegistration.Models
{
    public class CourseStudent
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }

        [Key]
        public int CourseId { get; set; }
    }
}
