using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCourse.Models
{
    public class TeacherCourseClass
    {
        public int TeacherCourseClassID { get; set; }

        public int TeacherCoureseID { get; set; }

        [ForeignKey("TeacherCoureseID")]
        public virtual TeacherCourse TeacherCourese { get; set; }
    }
}
