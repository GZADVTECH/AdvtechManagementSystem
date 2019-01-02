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
            //判断字段是否为空
            if (ValidateType.NullOrEmptyOfString(cbbName.Text, "货物名称")) return;
            if (ValidateType.NullOrEmptyOfString(cbbModal.Text, "货物型号")) return;
            if (ValidateType.NullOrEmptyOfString(txtCargoid.Text, "货物编号")) return;
            if (ValidateType.NullOrEmptyOfString(txtPurchase.Text, "采购价格")) return;
            if (ValidateType.NullOrEmptyOfString(txtSale.Text, "销售价格")) return;
            if (ValidateType.NullOrEmptyOfString(cbbWare.Text, "仓库位置")) return;
            if (ValidateType.NullOrEmptyOfString(cbbUnit.Text, "单位")) return;

            //进行出库操作，成功将仓库数量减少，失败则返回
            //货物信息数组
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("cargoid", txtCargoid.Text);
            data.Add("cargoname", cbbName.Text);
            data.Add("cargomodal", cbbModal.Text);
            data.Add("cargoamount", (Convert.ToInt32(nNum.Value) - Convert.ToInt32(nNum.Tag == null ? 0 : nNum.Tag)).ToString());//修改时增加数量而不是修改数量
            data.Add("cargopurchase", txtPurchase.Text);
            data.Add("cargosale", txtSale.Text);
            data.Add("cargoware", cbbWare.Text);
            data.Add("cargounit", cbbUnit.Text);
            data.Add("cargoremark", rtbRemark.Text);
            //出库信息数组
            Dictionary<string, string> deliverydata = new Dictionary<string, string>();
            deliverydata.Add("deluserid", userinfo.userid);
            deliverydata.Add("delcargo", txtCargoid.Text);
            deliverydata.Add("delamount", nNum.Value.ToString());
            deliverydata.Add("delprice", txtPurchase.Text);
            deliverydata.Add("deltotalprice", Convert.ToString(Convert.ToDecimal(txtPurchase.Text) * Convert.ToDecimal(nNum.Value)));
            deliverydata.Add("delremark", rtbRemark.Text);

            DataTable dt = DeliveryOperate.insertDelivery(deliverydata);
            if (dt.HasErrors)
            {
                Errorinfo.errorPost("出库数据添加失败。");
                tslStatus.Text = "出库数据添加失败，已反馈服务器，请稍后重试。";
                time.Start();
            }

            //减去仓库相对应的数量
            DataTable updatedt = CargoinfoOperate.updateCargoinfo(data);
            if (updatedt.HasErrors)
            {
                tslStatus.Text = "更新货物信息失败，已反馈服务器，请稍后重试。";
                time.Start();
                Errorinfo.errorPost("货物存在，选择更新货物信息操作失败。");
            }


            tslStatus.Text = "出库信息添加成功。";
            time.Start();
        }
        /// <summary>
        /// 默认加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWareOut_Load(object sender, EventArgs e)
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
            cbbName.DisplayMember = "Key";
            cbbName.ValueMember = "Value";
            cbbName.DataSource = bs;
        }
        /// <summary>
        /// 当备注控件激活时内容为空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbRemark_Enter(object sender, EventArgs e)
        {
            rtbRemark.Text = string.Empty;
        }
    }
}
