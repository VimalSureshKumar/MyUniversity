using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyUniversity.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Display(Name = "Student ID")]
        public string LastName { get; set; }
        [Display(Name = "Last Name")]
        public string FirstName { get; set; }
        [Display(Name = "First Name")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Enrollment Date")]
        public DateTime DOB { get; set; }
        [Display(Name = "Date of Birth")]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
