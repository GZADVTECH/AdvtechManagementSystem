using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BLL
{
    /// <summary>
    /// 验证
    /// </summary>
    public class ValidateType
    {
        /// <summary>
        /// 字符串验证是否为空
        /// </summary>
        /// <param name="data">验证信息</param>
        /// <param name="name">返回错误位置名称</param>
        /// <returns></returns>
        public static bool NullOrEmptyOfString(string data,string name)
        {
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show(string.Format("{0}不允许为空，请输入！", name), "系统提示");
                return true;
            }
            else
                return false;
        }
    }
}
