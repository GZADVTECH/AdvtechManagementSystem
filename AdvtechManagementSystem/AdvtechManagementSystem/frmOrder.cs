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
    public partial class frmOrder : Form
    {
        private DataTable dt = new DataTable();
        private Timer time = new Timer();
        int num = 1;
        public frmOrder()
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
        /// 提交按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //验证是否为空
            if (ValidateType.NullOrEmptyOfString(txtInternal.Text, "内部订单号")) return;
            if (ValidateType.NullOrEmptyOfString(txtOfficial.Text, "合同订单号")) return;
            if (ValidateType.NullOrEmptyOfString(cbbCargo.Text, "货物名称")) return;
            if (ValidateType.NullOrEmptyOfString(cbbModal.Text, "货物型号")) return;
            if (ValidateType.NullOrEmptyOfString(nNum.Value.ToString(), "采购数量")) return;
            if (ValidateType.NullOrEmptyOfString(txtPurchase.Text, "采购价格")) return;

            //采购仅仅是采购，直接上传到采购信息订单中，再进行审核
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("purinternal",txtInternal.Text);
            data.Add("purofficial",txtOfficial.Text);
            data.Add("purcargo",txtCargoid.Text);
            data.Add("puramount",nNum.Value.ToString());
            data.Add("purmatch",cbMatch.Checked.ToString());
            data.Add("purinvoice",cbInvoice.Checked.ToString());
            data.Add("purtotalprice",txtTotal.Text);
            data.Add("purremark", ((nNum.Tag == null ? string.Format(cbbCargo.Text + "___" + cbbModal.Text) : "") + "______") + rtbRemark.Text);
            dt = PurchaseOperate.insertPurchase(data);
            if (dt.HasErrors)
            {
                tslStatus.Text = "添加采购信息错误，已反馈服务器，请稍后重试。";
                time.Start();
                Errorinfo.errorPost("添加采购信息错误。");
                return;
            }
            tslStatus.Text = "添加采购信息成功。";
            time.Start();
            StringBuilder sb = new StringBuilder();
            sb.Append("内部订单号：" + txtInternal.Text);
            sb.Append("合同订单号：" + txtOfficial.Text);
            sb.Append("货物名称：" + cbbCargo.Text);
            sb.Append("货物型号：" + cbbModal.Text);
            sb.Append("货物编号：" + txtCargoid.Text);
            sb.Append("是否配套：" + (cbMatch.Checked?"是":"否"));
            sb.Append("附带发票：" + (cbInvoice.Checked?"是":"否"));
            sb.Append("数量：" + nNum.Value.ToString());
            sb.Append("采购价格：" + txtPurchase.Text);
            sb.Append("采购总值：" + txtTotal.Text);
            sb.Append("备注：" + ((nNum.Tag==null?string.Format(cbbCargo.Text+"___"+cbbModal.Text):"")+"______")+rtbRemark.Text);
            rtbContent.Text += sb.ToString();

            //清空相对应的信息
            cbMatch.Checked = false;
            cbInvoice.Checked = false;
            nNum.Value = 0;
            rtbRemark.Text = "如需标注是否含税，请在此处填写（例:采购价格不含税，销售价格含税）";
        }
        /// <summary>
        /// 默认加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrder_Load(object sender, EventArgs e)
        {
            //添加产品名称选项
            Dictionary<string, char> PItems = new Dictionary<string, char>();
            PItems.Add("扫描器", 'C');
            PItems.Add("打印头", 'D');
            PItems.Add("打印机", 'A');
            PItems.Add("连接线", 'L');
            PItems.Add("配件", 'P');
            PItems.Add("维修", 'W');
            PItems.Add("借货", 'J');
            PItems.Add("赠送", 'Z');
            PItems.Add("其他", 'B');
            BindingSource bs = new BindingSource();
            bs.DataSource = PItems;
            cbbCargo.DisplayMember = "Key";
            cbbCargo.ValueMember = "Value";
            cbbCargo.DataSource = bs;

            tslStatus.Text = "内容加载完毕。";
            time.Start();
        }
        /// <summary>
        /// 货物名称改变时获取相对应的型号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbCargo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbCargo.SelectedValue == null)
            {
                cbbModal.DataSource = null;
                txtCargoid.Text = string.Empty;
                nNum.Tag = null;
                return;
            }

            dt = CargoinfoOperate.selectCargoinfo(cbbCargo.Text);
            if (dt.HasErrors)
            {
                tslStatus.Text = "查询产品型号错误。";
                time.Start();
                Errorinfo.errorPost("查询产品型号错误。");
            }
            if (dt.Rows.Count <= 0)
            {
                cbbModal.DataSource = null;
                txtCargoid.Text = cbbCargo.SelectedValue.ToString() + "001";
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
        /// 判断是否存在，如果不存在其他信息为空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbModal_Leave(object sender, EventArgs e)
        {
            if (cbbModal.SelectedValue == null)
            {
                if (cbbModal.Tag == null) return;
                txtCargoid.Text = cbbCargo.SelectedValue.ToString() + string.Format("{0:000}", Convert.ToInt32(cbbModal.Tag) + 1);
                txtPurchase.Text = string.Empty;
                nNum.Tag = null;
                return;
            }
        }
        /// <summary>
        /// 选择产品型号后显示相应的货物编号
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
            nNum.Tag = Convert.ToInt32(dr["cargoamount"]);
        }
        /// <summary>
        /// 当数量改变时改变总值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nNum_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (Convert.ToDouble(string.IsNullOrEmpty(nNum.Value.ToString())?"0":nNum.Value.ToString()) * Convert.ToDouble(string.IsNullOrEmpty(txtPurchase.Text)?"0":txtPurchase.Text)).ToString();
        }
        /// <summary>
        /// 备注控件激活时内容为空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbRemark_Enter(object sender, EventArgs e)
        {
            rtbRemark.Text = string.Empty;
        }
        /// <summary>
        /// 备注控件失效时内容为提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbRemark_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbRemark.Text.Trim()))
                rtbRemark.Text = "如需标注是否含税，请在此处填写（例:采购价格不含税，销售价格含税）";
        }
    }
}
