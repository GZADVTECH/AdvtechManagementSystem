using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;
using MODEL;

namespace AdvtechManagementSystem
{
    public partial class frmLogin : Form
    {
        private string filename = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;//获取Bin文件位置
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 输入时是否存在类似数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string path = filename + "user.dll";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path, true);//创建文件读取流
                string str = sr.ReadLine();//读取文件流数据
                while (str != null)
                {
                    if (!this.txtName.AutoCompleteCustomSource.Contains(str))
                        this.txtName.AutoCompleteCustomSource.Add(str);
                    str = sr.ReadLine();
                }
                sr.Close();
            }
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //将之前登录成功的用户名登记到文本框中
            string path = filename + "user.dll";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path, true);
                string str = sr.ReadLine();
                txtName.Text = str;
                this.txtName.AutoCompleteCustomSource.Add(str);
                sr.Close();
            }
            else
            {
                File.Create(path);
            }
        }
        /// <summary>
        /// 登录点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLogin_Click(object sender, EventArgs e)
        {
            //验证是否为空
            if (ValidateType.NullOrEmptyOfString(txtName.Text, "用户名"))
                return;
            if (ValidateType.NullOrEmptyOfString(txtPwd.Text, "密码"))
                return;
            //验证是否存在该账号及密码是否一致
            if (UserinfoOperate.validateUserinfo(txtName.Text, txtPwd.Text))
            {
                string path = filename + "user.dll";
                if (File.Exists(path))
                {
                    if (!this.txtName.AutoCompleteCustomSource.Contains(this.txtName.Text))
                    {
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine(this.txtName.Text.Trim());
                        sw.Close();
                        if (!this.txtName.AutoCompleteCustomSource.Contains(this.txtName.Text))
                        {
                            this.txtName.AutoCompleteCustomSource.Add(this.txtName.Text);
                        }
                    }
                }
                //进入主界面
                switch (userinfo.userpower)
                {
                    case 1:frmManage manage = new frmManage();manage.Show(); break;
                    case 2:frmWarehouse warehouse = new frmWarehouse();warehouse.Show(); break;
                    case 3:frmPurchase purchase = new frmPurchase();purchase.Show(); break;
                    case 4: break;
                    default:
                        MessageBox.Show("无任何权限，请向最高管理员申请。", "系统提示");
                        Errorinfo.errorPost("无权限者试图登录");
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("账号或密码错误，请核实后重新输入！", "系统提示");
                txtPwd.SelectAll();
                return;
            }
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword forget = new frmForgetPassword();
            forget.ShowDialog();
        }
    }
}
