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
    public partial class frmWareOut : Form
    {
        private DataTable dt = new DataTable();
        private Timer time = new Timer();
        int num = 1;
        public frmWareOut()
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
        /// 查询出库记录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbOut_Click(object sender, EventArgs e)
        {
            string text = tstxtOut.Text;//查询文本
            DataTable dt = DeliveryOperate.select_delivery(text);
            if (dt.HasErrors)
            {
                tslStatus.Text = "查询失败，已反馈服务器，请稍后重新再试。";
                time.Start();
                Errorinfo.errorPost("查询出库记录失败。");
                return;
            }
            if (dt.Rows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataRow item in dt.Rows)
                {
                    sb.AppendLine("出库编号：" + item["delid"].ToString());
                    sb.AppendLine("出库产品编号：" + item["delcargo"].ToString());
                    sb.AppendLine("产品名称：" + item["cargoname"].ToString());
                    sb.AppendLine("产品型号：" + item["cargomodal"].ToString());
                    sb.AppendLine("出库数量：" + item["delamount"].ToString());
                    sb.AppendLine("出库单价：" + item["delprice"].ToString());
                    sb.AppendLine("出库总值：" + item["deltotalprice"].ToString());
                    sb.AppendLine("出库时间：" + item["deltime"].ToString());
                    sb.AppendLine("备注：" + item["delremark"].ToString());
                    sb.AppendLine("");
                }
                rtbContent.Text = sb.ToString();
            }
            else
                rtbContent.Text = "暂无该产品的相关记录。";
            tslStatus.Text = "查询成功。";
            time.Start();
        }
        /// <summary>
        /// 选择用户名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbName.SelectedValue == null)
            {
                cbbModal.DataSource = null;
                txtCargoid.Text = string.Empty;
                nNum.Tag = null;
                return;
            }

            dt = CargoinfoOperate.selectCargoinfo(cbbName.Text);
            if (dt.HasErrors)
            {
                tslStatus.Text = "查询产品型号错误。";
                time.Start();
                Errorinfo.errorPost("查询产品型号错误。");
            }
            if (dt.Rows.Count <= 0)
            {
                cbbModal.DataSource = null;
                txtCargoid.Text = cbbName.SelectedValue.ToString() + "001";
                cbbModal.Tag = 0;
                return;
            }
            Dictionary<string, string> items = new Dictionary<string, string>();
            foreach (DataRow item in dt.Rows)
                items.Add(item["cargomodal"].ToString(), item["cargoid"].ToString());
            BindingSource bs = new BindingSource();
            bs.DataSource = items;
            cbbModal.DisplayMember = "Key";
            cbbModal.ValueMember = "Value";
            cbbModal.DataSource = bs;
            cbbModal.Tag = dt.Rows.Count;
        }
        /// <summary>
        /// 选择型号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbModal_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbModal.SelectedValue == null) return;
            txtCargoid.Text = cbbModal.SelectedValue.ToString();
            nNum.Tag = null;
            if (cbbModal.SelectedIndex < 0) return;
            DataRow dr = dt.Rows[cbbModal.SelectedIndex];
            txtPurchase.Text = dr["cargopurchase"].ToString();
            txtSale.Text = dr["cargosale"].ToString();
            cbbWare.Text = dr["cargoware"].ToString();
            cbbUnit.Text = dr["cargounit"].ToString();
            rtbRemark.Text = dr["cargoremark"].ToString();
            nNum.Tag = Convert.ToInt32(dr["cargoamount"]);
        }
        /// <summary>
        /// SN码售出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSnid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (cbbModal.SelectedValue == null)
                {
                    rtbRecord.Text += "\n请在货物信息中选择添加SN码的货物信息。";
                    txtSnid.Text = string.Empty;
                    txtSnid.Focus();
                    return;
                }
                if (SerialOperate.deleteSerial(cbbModal.SelectedValue.ToString(), txtSnid.Text).HasErrors)
                {
                    rtbRecord.Text += "\n售出失败，已反馈服务器，请稍后重试。";
                    txtSnid.Text = string.Empty;
                    txtSnid.Focus();
                    return;
                }
                rtbRecord.Text += "\n售出成功，货物编号：" + cbbModal.SelectedValue.ToString() + "SN码：" + txtSnid.Text + "。";
                txtSnid.Text = string.Empty;
                txtSnid.Focus();
            }
        }
        /// <summary>
        /// 提交事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
