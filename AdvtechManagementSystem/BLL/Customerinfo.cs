using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Customerinfo
    {
        /// <summary>
        /// 查询详细的供应商信息
        /// </summary>
        /// <returns></returns>
        public static DataTable selectCustomer()
        {
            DataTable dt = SQLHelper.QueryDataTable("SQL", "select * from view_customerinfo", null, CommandType.Text);
            return dt;
        }
    }
}
