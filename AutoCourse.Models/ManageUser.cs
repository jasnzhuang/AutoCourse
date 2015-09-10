using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCourse.Models
{
    public class ManageUser
    {
        [Required]
        [Key]
        public int UserID { get; set; }
                
        public int SchoolID { get; set; }
        

        [ForeignKey("SchoolID")]
        public School School { get; set; } 
    }
}
