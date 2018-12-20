using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AdvtechManagementSystem
{
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 提交按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateType.NullOrEmptyOfString(txtName.Text, "用户名"))
                return;
            if (ValidateType.NullOrEmptyOfString(txtOpwd.Text, "旧密码"))
                return;
            if (ValidateType.NullOrEmptyOfString(txtNpwd.Text, "新密码"))
                return;
            if (ValidateType.NullOrEmptyOfString(txtRpwd.Text, "重新输入密码"))
                return;
            if (txtNpwd.Text.Equals(txtRpwd.Text))
            {
                MessageBox.Show("新密码与重输入不一致", "系统提示");
                txtRpwd.SelectAll();
                return;
            }
            if (UserinfoOperate.validateUserinfo(txtName.Text, txtOpwd.Text))
            {
                if (UserinfoOperate.changePassword(txtName.Text, txtNpwd.Text))
                {
                    MessageBox.Show("修改成功！请使用新密码登录。", "系统提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败，已将错误情况报告，请稍后重试！", "系统提示");
                    //错误报告
                    Errorinfo.errorPost("修改密码失败");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("用户不存在或密码错误，请核实后重新输入！", "系统提示");
                txtOpwd.SelectAll();
                return;
            }
        }
    }
}