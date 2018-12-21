using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvtechManagementSystem
{
    public partial class frmUsermanage : Form
    {
        private DataTable dt = UserinfoOperate.selectUserinfo();//所有用户信息
        private Timer time = new Timer();
        int num = 1;
        public frmUsermanage()
        {
            InitializeComponent();
            time.Interval = 1000;
            time.Tick += new EventHandler(TimerMessage);
        }
        /// <summary>
        /// 默认加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUsermanage_Load(object sender, EventArgs e)
        {
            //获取所有用户信息
            lbUser.Items.Clear();
            if (dt.Rows.Count==0)
            {
                lbUser.Items.Add("暂无成员");
                tsslStatus.Text = "所有用户信息加载完成。";
                time.Start();
                return;
            }
            lbUser.DisplayMember = "username";
            lbUser.ValueMember = "userid";
            lbUser.DataSource = dt;

            tsslStatus.Text = "所有用户信息加载完成。";
            time.Start();
        }
        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            string selecttext = tstText.Text;//查询内容
            lbUser.DataSource = null;
            lbUser.Items.Clear();
            DataTable dtSelect;
            if (string.IsNullOrEmpty(selecttext))
                dtSelect = UserinfoOperate.selectUserinfo();
            else
                dtSelect = UserinfoOperate.selectUserinfo(selecttext);
            if (dtSelect.Rows.Count==0)
            {
                lbUser.Items.Add("暂无成员");
                tsslStatus.Text = "查询内容加载完成。";
                time.Start();
                return;
            }
            lbUser.DisplayMember = "username";
            lbUser.ValueMember = "userid";
            lbUser.DataSource = dtSelect;
            tsslStatus.Text = "查询内容加载完成。";
            time.Start();
        }
        /// <summary>
        /// 选择值改变时改变其内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbUser_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            object value = lb.SelectedValue;//获取选中的值
            if(value==null)
            {
                rtbUser.Text = "暂无详细信息";
                return;
            }
            DataRow dtc = dt.Rows[lb.SelectedIndex];
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("用户编号："+dtc["userid"].ToString());
            sb.AppendLine("用户姓名："+dtc["username"].ToString());
            sb.AppendLine("性别："+(Convert.ToBoolean(dtc["usergender"])==false?"男":"女"));
            sb.AppendLine("出生日期：" +(dtc["userbirth"]==null?"":Convert.ToDateTime(dtc["userbirth"]).ToShortDateString()));
            sb.AppendLine("所属部门：" + (dtc["userdepart"] == null ? "" : dtc["userdepart"].ToString()));
            sb.AppendLine("职务：" + (dtc["userpost"] == null ? "" : dtc["userpost"].ToString()));
            sb.AppendLine("联系方式：" + (dtc["usercontact"] == null ? "" : dtc["usercontact"].ToString()));
            sb.AppendLine("联系地址：" + (dtc["useraddress"] == null ? "" : dtc["useraddress"].ToString()));
            sb.AppendLine("备注：" + (dtc["userremark"] == null ? "" : dtc["userremark"].ToString()));
            sb.AppendLine("权限：" + (dtc["userpower"] == null ? "无权限" : Convert.ToInt32(dtc["userpower"]) == 1 ? "最高管理" :
                Convert.ToInt32(dtc["userpower"]) == 2 ? "仓库管理" : Convert.ToInt32(dtc["userpower"]) == 3 ? "采购管理" :
                Convert.ToInt32(dtc["userpower"]) == 4 ? "行政管理" : Convert.ToInt32(dtc["userpower"]) == 5 ? "技术管理" :
                Convert.ToInt32(dtc["userpower"]) == 6 ? "售后管理" : Convert.ToInt32(dtc["userpower"]) == 7 ? "客服管理" : "其他权限"));
            rtbUser.Text = sb.ToString();
        }
        /// <summary>
        /// 为活动控件时内容为空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstText_Enter(object sender, EventArgs e)
        {
            ToolStripTextBox tst=(ToolStripTextBox)sender;
            tst.Text = string.Empty;
        }
        /// <summary>
        /// 初始化（保留用户名，其余的为空）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btninitialize_Click(object sender, EventArgs e)
        {
            if (lbUser.SelectedValue==null)
            {
                MessageBox.Show("请选择需要初始化的用户。", "系统提示");
                return;
            }
            if(MessageBox.Show("是否初始化？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataTable dtinitial = UserinfoOperate.initializeUserinfo(Convert.ToInt32(lbUser.SelectedValue));
                    if (dtinitial.Rows.Count==0)
                    {
                        Errorinfo.errorPost("用户初始化中失败");
                        tsslStatus.Text = "初始化失败，已经反馈服务器，请稍候再试！";
                        time.Start();
                        return;
                    }
                    tsslStatus.Text = "初始化成功。";
                    time.Start();

                    lbUser.DisplayMember = "username";
                    lbUser.ValueMember = "userid";
                    lbUser.DataSource = dt;
                }
                catch (Exception ex)
                {
                    Errorinfo.errorPost("用户初始化中出现问题，问题如下：" + ex.Message);
                    tsslStatus.Text="初始化失败，已经反馈服务器，请稍候再试！";
                    time.Start();
                    return;
                }
            }
        }
        /// <summary>
        /// 设置倒计时显示
        /// </summary>
        /// <param name="text"></param>
        private void TimerMessage(object sender,EventArgs e)
        {
            num++;
            if (num>=3)
            {
                num = 0;
                time.Enabled = false;
                tsslStatus.Text = string.Empty;
            }
        }
    }
}
