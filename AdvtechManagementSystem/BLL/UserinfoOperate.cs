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
                userinfo.userpower=Convert.ToInt32(dt.Rows[0]["userpower"]);
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
        /// <summary>
        /// 查询所有的用户信息
        /// </summary>
        /// <returns></returns>
        public static DataTable selectUserinfo()
        {
            DataTable dt = SQLHelper.QueryDataTable("SQL", "select * from view_userinfo", null, CommandType.Text);
            return dt;
        }
        /// <summary>
        /// 通过查询条件查询用户信息
        /// </summary>
        /// <param name="select"></param>
        /// <returns></returns>
        public static DataTable selectUserinfo(string select)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@selcttext",select)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_select_userinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 初始化用户信息
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static DataTable initializeUserinfo(int userid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@userid",userid),
                new SqlParameter("@userpwd",MD5Encrypt.MD5Encrypt32("123456")),
                new SqlParameter("@usergender",false),
                new SqlParameter("@userbirth",""),
                new SqlParameter("@userdepart",""),
                new SqlParameter("@userpost",""),
                new SqlParameter("@usercontact",""),
                new SqlParameter("@useraddress",""),
                new SqlParameter("@userremark",""),
                new SqlParameter("@userstatus",1),
                new SqlParameter("@userpower","0")
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_update_userinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable insertUserinfo(Dictionary<string,object> data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@username",data["username"]),
                new SqlParameter("@userpwd",MD5Encrypt.MD5Encrypt32("123456")),
                new SqlParameter("@usergender",data["usergender"]),
                new SqlParameter("@userbirth",data["userbirth"]),
                new SqlParameter("@userdepart",data["userdepart"]),
                new SqlParameter("@userpost",data["userpost"]),
                new SqlParameter("@usercontact",data["usercontact"]),
                new SqlParameter("@useraddress",data["useraddress"]),
                new SqlParameter("@userremark",data["userremark"]),
                new SqlParameter("@userpower",data["userpower"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_insert_userinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable updateUserinfo(Dictionary<string,object> data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@userid",data["userid"]),
                new SqlParameter("@username",data["username"]),
                new SqlParameter("@usergender",data["usergender"]),
                new SqlParameter("@userbirth",data["userbirth"]),
                new SqlParameter("@userdepart",data["userdepart"]),
                new SqlParameter("@userpost",data["userpost"]),
                new SqlParameter("@usercontact",data["usercontact"]),
                new SqlParameter("@useraddress",data["useraddress"]),
                new SqlParameter("@userremark",data["userremark"]),
                new SqlParameter("@userpower",data["userpower"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_update_userinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable deleteUserinfo(object id)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@userid",id)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_delete_userinfo", param, CommandType.StoredProcedure);
            return dt;
        }
    }
}
