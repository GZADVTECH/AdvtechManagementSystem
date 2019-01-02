using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeliveryOperate
    {
        /// <summary>
        /// 出库信息查询
        /// </summary>
        /// <param name="selecttext"></param>
        /// <returns></returns>
        public static DataTable select_delivery(string selecttext)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@selecttext",selecttext)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_select_delivery", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 出库信息插入
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable insertDelivery(Dictionary<string, string> data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@deluserid",data["deluserid"]),
                new SqlParameter("@delcargo",data["delcargo"]),
                new SqlParameter("@delamount",data["delamount"]),
                new SqlParameter("@delprice",data["delprice"]),
                new SqlParameter("@deltotalprice",data["deltotalprice"]),
                new SqlParameter("@deltime",DateTime.Now),
                new SqlParameter("@delremark",data["delremark"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_insert_delivery", param, CommandType.StoredProcedure);
            return dt;
        }
    }
}
