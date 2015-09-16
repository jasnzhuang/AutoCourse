using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCourse.BLL
{
    public class ACBaseExecService
    {
        public static int ExecSQL(string sqlstr, params object[] p)
        {
            return AutoCourse.DAL.ACBaseExec.ExecSQLCommand(sqlstr, p);
        }
    }
}
