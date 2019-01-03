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
        /// <summary>
        /// 审核情况查询
        /// </summary>
        /// <returns></returns>
        public static DataTable selectAuditing()
        {
            DataTable dt = SQLHelper.QueryDataTable("SQL", "select * from auditing where audstatus=0", null, CommandType.Text);
            return dt;
        }
        /// <summary>
        /// 查询采购订单情况
        /// </summary>
        /// <returns></returns>
        public static DataTable selectPurchase()
        {
            DataTable dt = SQLHelper.QueryDataTable("SQL", "select * from view_purchase", null, CommandType.Text);
            return dt;
        }
        /// <summary>
        /// 添加审核信息
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable insertAuditing(Dictionary<string,string> data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@audpurchase",data["audpurchase"]),
                new SqlParameter("@auduser",data["auduser"]),
                new SqlParameter("@audstatus",data["audstatus"]),
                new SqlParameter("@audremark",data["audremark"]),
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_insert_auditing", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 获取当月的库存情况
        /// </summary>
        /// <returns></returns>
        public static DataTable selectmonthcargoinfo()
        {
            SqlParameter[] param =
            {
                new SqlParameter("@starttime",DateTime.Now.AddDays(1 - DateTime.Now.Day).Date),
                new SqlParameter("@endtime",DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddMonths(1).AddSeconds(-1))
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_month_cargoinfo", param, CommandType.StoredProcedure);
            return dt;
        }
    }
}
