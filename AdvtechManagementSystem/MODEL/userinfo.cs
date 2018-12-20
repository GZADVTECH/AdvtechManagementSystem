using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    /// <summary>
    /// 个人用户信息
    /// </summary>
    public static class userinfo
    {
        /// <summary>
        /// 个人用户ID
        /// </summary>
        public static string userid { get; set; }
        /// <summary>
        /// 个人用户名
        /// </summary>
        public static string username { get; set; }
        /// <summary>
        /// 个人用户性别
        /// </summary>
        public static bool usergender { get; set; }
        /// <summary>
        /// 个人备注
        /// </summary>
        public static string userremark { get; set; }
        /// <summary>
        /// 用户权限
        /// </summary>
        public static int userpower { get; set; }
    }
}
