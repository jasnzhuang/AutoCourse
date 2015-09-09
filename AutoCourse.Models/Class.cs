using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AutoCourse.Models
{
    public class Class
    {
        public int ClassID { get; set; }

        [Required]
        public string ClassName { get; set; }        

        public virtual ICollection<TeacherCourseClass> TeacherCourseClasses { get; set; }
    }
}
