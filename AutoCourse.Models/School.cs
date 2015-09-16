using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel;

namespace AutoCourse.Models
{
    public class School
    {

        /// <summary>
        /// 学校ID
        /// </summary>
        [Required]
        public int SchoolID { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [Required]
        [DisplayName("学校名称")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学期
        /// </summary>
        public virtual ICollection<Term> Terms { get; set; }

        /// <summary>
        /// 学校管理员
        /// </summary>
        public virtual ICollection<ManageUser> ManageUsers { get; set; }

        /// <summary>
        /// 学校班级
        /// </summary>
        public virtual ICollection<Class> Classes { get; set; }

        /// <summary>
        /// 学校课程
        /// </summary>
        public virtual ICollection<Course> Courses { get; set; }
    }
}