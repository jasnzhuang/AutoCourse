using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCourse.Models
{
    public class TeacherCourse
    {
        public int TeacherCourseID { get; set; }

        public int TeacherID { get; set; }

        [ForeignKey("TeacherID")]
        public virtual Teacher Teacher { get; set; }

        public int CourseID { get; set; }

        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }

        public virtual ICollection<TeacherCourseClass> TeacherCourseClasses { get; set; }

    }
}
