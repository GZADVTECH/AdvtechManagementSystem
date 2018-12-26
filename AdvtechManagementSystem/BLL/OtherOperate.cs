using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class OtherOperate
    {
        /// <summary>
        /// 搜索序列号
        /// </summary>
        /// <returns></returns>
        public static DataTable selectSerial(string serid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@serid",serid)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_select_serial", param, CommandType.StoredProcedure);
            return dt;
        }
    }
}
