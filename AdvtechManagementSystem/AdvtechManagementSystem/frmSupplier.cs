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
    public partial class frmSupplier : Form
    {
        DataTable dt = new DataTable();
        Timer time = new Timer();
        int num = 1;
        public frmSupplier()
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
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            dt = Customerinfo.selectCustomer();
            if (dt.HasErrors)
            {
                tslStatus.Text = "加载供应商信息失败，已反馈服务器，请稍后重试。";
                time.Start();
                Errorinfo.errorPost("加载供应商信息失败。");
                return;
            }
            lbSupplier.ValueMember = "customid";
            lbSupplier.DisplayMember = "customname";
            lbSupplier.DataSource = dt;
            tslStatus.Text = "加载供应商信息成功。";
            time.Start();
        }
        /// <summary>
        /// 设置倒计时显示
        /// </summary>
        /// <param name="text"></param>
        private void TimerMessage(object sender, EventArgs e)
        {
            num++;
            if (num >= 3)
            {
                num = 0;
                time.Enabled = false;
                tslStatus.Text = string.Empty;
            }
        }

        private void lbSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            rtbContent.Text = string.Empty;
            if (lbSupplier.SelectedValue == null) return;
            //显示详细的信息
            DataRow[] dr = dt.Select("customid=" + lbSupplier.SelectedValue.ToString());
            StringBuilder sb = new StringBuilder();
            if (dr.Count() == 0) return;
            foreach (DataRow item in dr)
            {
                sb.AppendLine("销售商编号：" + item["customid"].ToString());
                sb.AppendLine("销售商名称：" + item["customname"].ToString());
                sb.AppendLine("销售商负责人：" + item["custompeople"].ToString());
                sb.AppendLine("销售商电话：" + item["customcontact"].ToString());
                sb.AppendLine("销售商地址：" + item["customaddress"].ToString());
                sb.AppendLine("备注：" + item["customremark"].ToString());
                sb.AppendLine("状态：" + item["customstatus"].ToString());
            }
            rtbContent.Text = sb.ToString();
        }
        /// <summary>
        /// 双击显示详细内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbSupplier_DoubleClick(object sender, EventArgs e)
        {
            if (lbSupplier.SelectedValue == null) return;
            DataRow[] dr = dt.Select("customid=" + lbSupplier.SelectedValue.ToString());
            if (dr.Count() == 0) return;
            gbMessage.Tag = dr[0]["customid"];
            txtCompanyname.Text = dr[0]["customname"].ToString();
            txtPeople.Text = dr[0]["custompeople"].ToString();
            txtPhone.Text = dr[0]["customcontact"].ToString();
            txtAddress.Text = dr[0]["customaddress"].ToString();
            txtRemark.Text = dr[0]["customremark"].ToString();
            cbStatus.Checked = Convert.ToBoolean(dr[0]["customstatus"]);
        }
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            rtbContent.Text = string.Empty;
            DataRow[] dr = dt.Select("customid=" + tstxtStock.Text.Trim() + " or customname=" + tstxtStock.Text.Trim());
            StringBuilder sb = new StringBuilder();
            if (dr.Count() == 0) return;
            foreach (DataRow item in dr)
            {
                sb.AppendLine("销售商编号：" + item["customid"].ToString());
                sb.AppendLine("销售商名称：" + item["customname"].ToString());
                sb.AppendLine("销售商负责人：" + item["custompeople"].ToString());
                sb.AppendLine("销售商电话：" + item["customcontact"].ToString());
                sb.AppendLine("销售商地址：" + item["customaddress"].ToString());
                sb.AppendLine("备注：" + item["customremark"].ToString());
                sb.AppendLine("状态：" + item["customstatus"].ToString());
            }
            rtbContent.Text = sb.ToString();
        }
    }
}
