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
using MODEL;

namespace AdvtechManagementSystem
{
    public partial class frmAuditingManage : Form
    {
        private DataTable dt = new DataTable();
        private Timer time = new Timer();
        int num = 1;
        public frmAuditingManage()
        {
            InitializeComponent();
            time.Interval = 1000;
            time.Tick += new EventHandler(TimerMessage);
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
        /// <summary>
        /// 默认加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAuditingManage_Load(object sender, EventArgs e)
        {
            dt = OtherOperate.selectPurchase();
            if (dt.HasErrors)
            {
                tslStatus.Text = "查询采购订单审核详细错误.已反馈服务器，请稍后再试！";
                time.Start();
                Errorinfo.errorPost("查询采购订单审核详细错误。");
                return;
            }
            lbAuditing.ValueMember = "purinternal";
            lbAuditing.DisplayMember = "purid";
            lbAuditing.DataSource = dt;
        }
        /// <summary>
        /// 点击显示相对应的详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbAuditing_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbAuditing.SelectedValue == null) return;
            StringBuilder sb = new StringBuilder();
            //DataRow[] dr = (dt.Select("purinternal=" + lbAuditing.SelectedValue.ToString())==null?null: dt.Select("purinternal=" + lbAuditing.SelectedValue.ToString()));
            DataRow[] dr = dt.Select("purinternal='"+ lbAuditing.SelectedValue.ToString() + "'");
            if (dr.Count() == 0) return;
                sb.AppendLine("采购订单号：" + dr[0]["purid"].ToString());
                sb.AppendLine("合同订单号："+dr[0]["purofficial"].ToString());
                sb.AppendLine("内部订单号：" + dr[0]["purinternal"].ToString());
            foreach (DataRow item in dr)
            {
                sb.AppendLine("货物编号："+item["purcargo"].ToString());
                sb.AppendLine("货物名称：" + item["cargoname"].ToString());
                sb.AppendLine("货物型号：" + item["cargomodal"].ToString());
                sb.AppendLine("采购数量："+item["puramount"].ToString());
                sb.AppendLine("是否配套产品："+(Convert.ToBoolean(item["purmatch"])?"是":"否"));
                sb.AppendLine("是否附带发票："+(Convert.ToBoolean(item["purinvoice"]) ? "是" : "否"));
                sb.AppendLine("采购总值："+item["purtotalprice"].ToString());
                sb.AppendLine("下单时间："+item["purtime"].ToString());
                sb.AppendLine("备注:"+item["purremark"].ToString());
                sb.AppendLine();
            }
            rtbContent.Text = sb.ToString();
        }
        /// <summary>
        /// 通过审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((string.IsNullOrEmpty(rtbRemark.Text)?"备注未填写，":"")+"是否确定提交？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lbAuditing.SelectedValue == null) return;

                string id = lbAuditing.SelectedValue.ToString();//获取ID
                //同意与否都要写入审核信息，同意则保留采购信息将状态转为是，不同意则删除采购信息
                DataRow[] dr = dt.Select("purinternal='" + lbAuditing.SelectedValue.ToString()+"'");
                if (dr.Count() == 0) return;
                List<string> errordata = new List<string>();
                foreach (DataRow item in dr)
                {
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    data.Add("audpurchase", item["purid"].ToString());
                    data.Add("auduser", userinfo.userid);
                    data.Add("audstatus", "1");
                    data.Add("audremark",string.IsNullOrEmpty(rtbRemark.Text)?"":rtbRemark.Text);
                    if (OtherOperate.insertAuditing(data).HasErrors)
                    {
                        tslStatus.Text = "审核出现错误，已反馈服务器，请稍后重试！";
                        time.Start();
                        Errorinfo.errorPost("审核添加信息出现错误。");
                        errordata.Add(item["purid"].ToString());
                        return;
                    }
                    if (PurchaseOperate.updatePurchase(item["purid"].ToString()).HasErrors)
                    {
                        tslStatus.Text = "更改订单状态错误，已反馈服务器，请稍后重试！";
                        time.Start();
                        Errorinfo.errorPost("更改订单状态错误。");
                    }
                }
                if (errordata.Count>0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (string errors in errordata)
                    {
                        sb.Append(errors);
                        sb.Append(",");
                    }
                    string datas = sb.ToString();
                    datas.Substring(0, datas.Length - 1);
                    tslStatus.Text = "审核出现错误，错误内容如下：" + datas;
                    return;
                }
                tslStatus.Text = "审核成功。";
                time.Start();
            }
        }
        /// <summary>
        /// 驳回审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((string.IsNullOrEmpty(rtbRemark.Text) ? "备注未填写，" : "") + "是否确定提交？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lbAuditing.SelectedValue == null) return;

                string id = lbAuditing.SelectedValue.ToString();//获取ID
                //同意与否都要写入审核信息，同意则保留采购信息将状态转为是，不同意则删除采购信息
                DataRow[] dr = dt.Select("purinternal=" + lbAuditing.SelectedValue.ToString());
                if (dr.Count() == 0) return;
                List<string> errordata = new List<string>();
                foreach (DataRow item in dr)
                {
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    data.Add("audpurchase", item["purid"].ToString());
                    data.Add("auduser", userinfo.userid);
                    data.Add("audstatus", "0");
                    data.Add("audremark", string.IsNullOrEmpty(rtbRemark.Text) ? "" : rtbRemark.Text);
                    if (OtherOperate.insertAuditing(data).HasErrors)
                    {
                        tslStatus.Text = "审核出现错误，已反馈服务器，请稍后重试！";
                        time.Start();
                        Errorinfo.errorPost("审核添加信息出现错误。");
                        errordata.Add(item["purid"].ToString());
                        return;
                    }
                    if (PurchaseOperate.deletePurchase(item["purid"].ToString()).HasErrors)
                    {
                        tslStatus.Text = "更改订单状态错误，已反馈服务器，请稍后重试！";
                        time.Start();
                        Errorinfo.errorPost("删除采购订单状态错误。");
                    }
                }
                if (errordata.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (string errors in errordata)
                    {
                        sb.Append(errors);
                        sb.Append(",");
                    }
                    string datas = sb.ToString();
                    datas.Substring(0, datas.Length - 1);
                    tslStatus.Text = "审核出现错误，错误内容如下：" + datas;
                    return;
                }
                tslStatus.Text = "审核成功。";
                time.Start();
            }
        }
    }
}
