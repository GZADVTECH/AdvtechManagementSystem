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
    public class userinfo
    {
        /// <summary>
        /// 个人用户ID
        /// </summary>
        public int userid { get; set; }
        /// <summary>
        /// 个人用户名
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 个人用户性别
        /// </summary>
        public bool usergender { get; set; }
        /// <summary>
        /// 个人备注
        /// </summary>
        public string userremark { get; set; }
    }
}
