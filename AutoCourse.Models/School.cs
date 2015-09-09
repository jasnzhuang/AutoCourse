using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AutoCourse.Models
{
    public class School 
    {
        
        public int SchoolID { get; set; }

        [Required]
        public string SchoolName { get; set; }

        [Required]
        public string UserID { get; set; }
        
        public virtual ICollection<Teacher> Teachers { get; set; }

        public virtual ICollection<Term> Terms { get; set; }
    }
}