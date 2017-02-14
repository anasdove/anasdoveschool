using System.ComponentModel.DataAnnotations;

namespace AnasDoveSchool.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Display(Name = "Name")]
        public string TeacherName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
