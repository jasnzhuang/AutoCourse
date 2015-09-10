using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AutoCourse.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        
        [Required]
        [Index("idx_Teacher_SchoolIDAndTeacherName", Order = 2, IsUnique = true)]
        [MaxLength(50)]
        public string TeacherName { get; set; }

        [Required]
        [Index("idx_Teacher_SchoolIDAndTeacherName", Order = 1, IsUnique = true)]
        public int SchoolID { get; set; }        

        public virtual ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}
