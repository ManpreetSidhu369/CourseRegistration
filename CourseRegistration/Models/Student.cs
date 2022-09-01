namespace CourseRegistration.Models
{
    public class Student
    {
        
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }   
        public int PhoneNo { get; set; }

        public List<Course> courses { get; set; }
    }
}