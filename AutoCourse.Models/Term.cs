using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCourse.Models
{
    public enum TermType
    {
        上学期 = 1,
        下学期 = 2,
    }

    public class Term
    {
        public int TermID { get; set; }

        public int TermYear { get; set; }
        public TermType TermType { get; set; }

        public int SchoolID { get; set; }

        [ForeignKey("SchoolID")]
        public School School { get; set; }
    }
}
