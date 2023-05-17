using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyUniversity.Models
{
    public class Student
    {
        [Display(Name = "Full Name")]
        [NotMapped]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public int StudentID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        [DataType(DataType.Text)]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
