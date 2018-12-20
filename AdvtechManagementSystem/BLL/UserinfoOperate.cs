using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
using MODEL;

namespace BLL
{
    /// <summary>
    /// 用户信息操作类
    /// </summary>
    public class UserinfoOperate
    {
        /// <summary>
        /// 登录验证是否存在该用户名以及密码
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool validateUserinfo(string name,string pwd)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@username",name),
                new SqlParameter("@userpwd",MD5Encrypt.MD5Encrypt32(pwd))
        };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_select_userinfo_contains", param, CommandType.StoredProcedure);
            if (dt.Rows.Count > 0)
            {
                //将获取的数据导入到静态用户信息类
                userinfo.userid =dt.Rows[0]["userid"].ToString();
                userinfo.username = dt.Rows[0]["username"].ToString();
                userinfo.usergender = Convert.ToBoolean(dt.Rows[0]["usergender"]);
                userinfo.userremark = dt.Rows[0]["userremark"].ToString();
                return true;
            }
            return false;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="newpwd">新密码</param>
        /// <returns></returns>
        public static bool changePassword(string name,string pwd)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@username",name),
                new SqlParameter("@userpwd",pwd)
        };
            int status = SQLHelper.Execute("SQL", "pro_update_userinfo", param, CommandType.StoredProcedure);
            if (status > 0)
                return true;
            else
                return false;
        }
    }
}
