using System.ComponentModel.DataAnnotations;

namespace AnasDoveSchool.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Display(Name = "Name")]
        public string CourseName { get; set; }
        public int Capacity { get; set; }
    }
}
