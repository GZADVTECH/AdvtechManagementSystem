using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class SerialOperate
    {
        /// <summary>
        /// 插入序列号
        /// </summary>
        /// <param name="serid"></param>
        /// <param name="sersnid"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        public static DataTable insertSerial(string serid,string sersnid,string remark)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@serid",serid),
                new SqlParameter("@sersnid",sersnid),
                new SqlParameter("@serremark",remark)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_insert_serial", param, CommandType.StoredProcedure);
            return dt;
        }

        public static DataTable deleteSerial(string serid, string sersnid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@serid",serid),
                new SqlParameter("@sersnid",sersnid),
                new SqlParameter("@@serstatus",false)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_delete_serial", param, CommandType.StoredProcedure);
            return dt;
        }
    }
}
