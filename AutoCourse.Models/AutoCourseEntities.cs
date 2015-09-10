using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Runtime.Remoting.Messaging;

namespace AutoCourse.Models
{
    public class AutoCourseEntities : DbContext
    {

        public AutoCourseEntities()
            : base("name=AutoCourseDBConnectionString")
        {

        }
        public DbSet<School> Schools { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<Term> Terms { get; set; }

        public DbSet<TeacherCourse> TeacherCourses { get; set; }

        public DbSet<TeacherCourseClass> TeacherCoureseClasses { get; set; }

        public DbSet<ManageUser> ManageUsers { get; set; }

    }
}
