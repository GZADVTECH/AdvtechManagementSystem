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
    public class CargoinfoOperate
    {
        /// <summary>
        /// 查询所有的货物
        /// </summary>
        /// <returns></returns>
        public static DataTable selectCargoinfo()
        {
            DataTable dt = SQLHelper.QueryDataTable("SQL", "select * from view_cargoinfo", null, CommandType.Text);
            return dt;
        }
        /// <summary>
        /// 页数查询数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static DataTable selectCargoinfoPage(int start,int end)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@start",start),
                new SqlParameter("@end",end)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_select_cargoinfo_page", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 通过条件查询货物
        /// </summary>
        /// <param name="selecttext"></param>
        /// <returns></returns>
        public static DataTable selectCargoinfo(string selecttext)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@selecttext",selecttext)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_select_cargoinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 添加货物信息
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable insertCargoinfo(Dictionary<string,string> data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@cargoid",data["cargoid"]),
                new SqlParameter("@cargoname",data["cargoname"]),
                new SqlParameter("@cargomodal",data["cargomodal"]),
                new SqlParameter("@cargoamount",data["cargoamount"]),
                new SqlParameter("@cargopurchase",data["cargopurchase"]),
                new SqlParameter("@cargosale",data["cargosale"]),
                new SqlParameter("@cargoware",data["cargoware"]),
                new SqlParameter("@cargounit",data["cargounit"]),
                new SqlParameter("@cargotime",DateTime.Now),
                new SqlParameter("@cargoremark",data["cargoremark"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_insert_cargoinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 更新库存信息
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable updateCargoinfo(Dictionary<string,string> data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@cargoid",data["cargoid"]),
                new SqlParameter("@cargoname",data["cargoname"]),
                new SqlParameter("@cargomodal",data["cargomodal"]),
                new SqlParameter("@cargoamount",data["cargoamount"]),
                new SqlParameter("@cargopurchase",data["cargopurchase"]),
                new SqlParameter("@cargosale",data["cargosale"]),
                new SqlParameter("@cargoware",data["cargoware"]),
                new SqlParameter("@cargounit",data["cargounit"]),
                new SqlParameter("@cargotime",DateTime.Now),
                new SqlParameter("@cargoremark",data["cargoremark"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_insert_cargoinfo", param, CommandType.StoredProcedure);
            return dt;
        }
    }
}
