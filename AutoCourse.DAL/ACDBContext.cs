using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AutoCourse.DAL
{
    public class ACDBContext
    {
        public static AutoCourse.Models.AutoCourseEntities GetCurrDBContext()
        {
            AutoCourse.Models.AutoCourseEntities ae = (AutoCourse.Models.AutoCourseEntities)CallContext.GetData("AutoCourseEntities");
            if (ae == null)
            {
                ae = new AutoCourse.Models.AutoCourseEntities();
                CallContext.SetData("AutoCourseEntities", ae);
            }
            return ae;
        }
    }
}
