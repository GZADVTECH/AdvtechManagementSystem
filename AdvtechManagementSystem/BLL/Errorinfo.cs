using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Errorinfo
    {
        public static void errorPost(string errormsg)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@errormsg",errormsg),
                new SqlParameter("@errortime",DateTime.Now.ToString())
            };
            int status = DAL.SQLHelper.Execute("SQL", "insert into errorinfo values(@errormsg,@errortime)", param, System.Data.CommandType.Text);
            //无需响应
        }
    }
}
