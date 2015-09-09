using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AutoCourse.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        [Required]
        public string CourseName { get; set; }

        public virtual ICollection<TeacherCourse> TeacherCoureses { get; set; }      

    }
}
