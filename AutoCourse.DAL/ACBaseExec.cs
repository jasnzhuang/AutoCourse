using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCourse.DAL
{
    public class ACBaseExec
    {
        public static int ExecSQLCommand(string sqlstr,params object[] p)
        {
            return ACDBContext.GetCurrDBContext().Database.ExecuteSqlCommand(sqlstr,p);
        }
    }
}
