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
    public class WarehousingOperate
    {
        /// <summary>
        /// 条件查询入库记录
        /// </summary>
        /// <param name="selecttext"></param>
        /// <returns></returns>
        public static DataTable selectWareHousing(string selecttext)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@selecttext",selecttext)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_select_warehousing", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 入库信息插入
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable insertWareHousing(Dictionary<string,string> data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@wareuserid",data["wareuserid"]),
                new SqlParameter("@warecargo",data["warecargo"]),
                new SqlParameter("@warecount",data["warecount"]),
                new SqlParameter("@wareprice",data["wareprice"]),
                new SqlParameter("@waretotalprice",data["waretotalprice"]),
                new SqlParameter("@waretime",DateTime.Now),
                new SqlParameter("@wareware",data["wareware"]),
                new SqlParameter("@wareremark",data["wareremark"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_insert_warehousing", param, CommandType.StoredProcedure);
            return dt;
        }
    }
}
