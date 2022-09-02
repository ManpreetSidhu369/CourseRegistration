using Microsoft.EntityFrameworkCore;

namespace CourseRegistration.Models
{
    public class RegistrationContext:DbContext
    {


        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Instructors> instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8QD3CHR\SQLEXPRESS; Database=CourseRegistration1; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(c => c.students)
                .WithMany(s => s.courses);




        }
    }
}
