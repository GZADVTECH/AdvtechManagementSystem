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
    public class PurchaseOperate
    {
        /// <summary>
        /// 添加采购信息
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable insertPurchase(Dictionary<string,string> data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@purinternal",data["purinternal"]),
                new SqlParameter("@purofficial",data["purofficial"]),
                new SqlParameter("@purcargo",data["purcargo"]),
                new SqlParameter("@paramount",data["paramount"]),
                new SqlParameter("@parmatch",data["parmatch"]),
                new SqlParameter("@parinvoice",data["parinvoice"]),
                new SqlParameter("@partotalprice",data["partotalprice"]),
                new SqlParameter("@partime",DateTime.Now),
                new SqlParameter("@parremark",data["parremark"]),
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_insert_purchase", param, CommandType.StoredProcedure);
            return dt;
        }
    }
}
