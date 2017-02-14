using System.ComponentModel.DataAnnotations;

namespace AnasDoveSchool.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
