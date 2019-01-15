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
    public partial class frmWareIn : Form
    {
        private DataTable dt = new DataTable();
        private Timer time = new Timer();
        int num = 1;
        public frmWareIn()
        {
            InitializeComponent();
            time.Interval = 1000;
            time.Tick += new EventHandler(TimerMessage);
        }
        /// <summary>
        /// 查询入库记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbIn_Click(object sender, EventArgs e)
        {
            string text = tstxtIn.Text;//查询文本
            DataTable dt = WarehousingOperate.selectWareHousing(text);
            if (dt.HasErrors)
            {
                tssStatus.Text = "查询失败，已反馈服务器，请稍后重新再试。";
                time.Start();
                Errorinfo.errorPost("查询入库记录失败。");
                return;
            }
            if (dt.Rows.Count>0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataRow item in dt.Rows)
                {
                    sb.AppendLine("入库编号：" + item["wareid"].ToString());
                    sb.AppendLine("入库产品编号：" + item["warecargo"].ToString());
                    sb.AppendLine("产品名称：" + item["cargoname"].ToString());
                    sb.AppendLine("产品型号：" + item["cargomodal"].ToString());
                    sb.AppendLine("入库数量：" + item["warecount"].ToString());
                    sb.AppendLine("入库单价：" + item["wareprice"].ToString());
                    sb.AppendLine("入库总值：" + item["waretotalprice"].ToString());
                    sb.AppendLine("入库时间：" + item["waretime"].ToString());
                    sb.AppendLine("存入仓库：" + item["wareware"].ToString());
                    sb.AppendLine("备注：" + item["wareremark"].ToString());
                    sb.AppendLine("");
                }
                rtbContent.Text = sb.ToString();
            }else
                rtbContent.Text = "暂无该产品的相关记录。";
            tssStatus.Text = "查询成功。";
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
                tssStatus.Text = string.Empty;
            }
        }
        /// <summary>
        /// 默认加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWareIn_Load(object sender, EventArgs e)
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
        /// 选择产品名称之后显示相对应的产品型号
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
                tssStatus.Text = "查询产品型号错误。";
                time.Start();
                Errorinfo.errorPost("查询产品型号错误。");
            }
            if (dt.Rows.Count<=0)
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
        /// 选择产品型号之后显示相对应的产品编号
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
        /// 判断是否存在，不存在则其他信息为空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbModal_Leave(object sender, EventArgs e)
        {
            if (cbbModal.SelectedValue == null)
            {
                if (cbbModal.Tag == null) return;
                txtCargoid.Text = cbbName.SelectedValue.ToString() + string.Format("{0:000}", Convert.ToInt32(cbbModal.Tag) + 1);
                txtPurchase.Text = string.Empty;
                txtSale.Text = string.Empty;
                cbbWare.Text = string.Empty;
                cbbUnit.Text = string.Empty;
                rtbRemark.Text = string.Empty;
                return;
            }
        }
        /// <summary>
        /// 提交按钮，如果不存在新建，否则覆盖
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
            //货物信息数组
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("cargoid", txtCargoid.Text);
            data.Add("cargoname", cbbName.Text);
            data.Add("cargomodal", cbbModal.Text);
            data.Add("cargoamount", (Convert.ToInt32(nNum.Value)+Convert.ToInt32(nNum.Tag==null?0:nNum.Tag)).ToString());//修改时增加数量而不是修改数量
            data.Add("cargopurchase", txtPurchase.Text);
            data.Add("cargosale", txtSale.Text);
            data.Add("cargoware", cbbWare.Text);
            data.Add("cargounit", cbbUnit.Text);
            data.Add("cargoremark", rtbRemark.Text);
            //入库信息数组
            Dictionary<string, string> warehousingdata = new Dictionary<string, string>();
            warehousingdata.Add("wareuserid", userinfo.userid);
            warehousingdata.Add("warecargo", txtCargoid.Text);
            warehousingdata.Add("warecount", nNum.Value.ToString());
            warehousingdata.Add("wareprice", txtPurchase.Text);
            warehousingdata.Add("waretotalprice", Convert.ToString(Convert.ToDecimal(txtPurchase.Text) * Convert.ToDecimal(nNum.Value)));
            warehousingdata.Add("wareware", cbbWare.Text);
            warehousingdata.Add("wareremark", rtbRemark.Text);

            //判断是否存在该货物
            if (cbbModal.SelectedValue==null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("该货物不存在，是否添加货物？");
                sb.AppendLine("货物详细信息如下：");
                sb.AppendLine("货物编号：" + txtCargoid.Text);
                sb.AppendLine("货物名称：" + cbbName.Text);
                sb.AppendLine("货物型号：" + cbbModal.Text);
                sb.AppendLine("货物数量：" + nNum.Value.ToString());
                sb.AppendLine("采购价格：" + txtPurchase.Text);
                sb.AppendLine("销售价格：" + txtSale.Text);
                sb.AppendLine("货物备注：" + rtbRemark.Text);
                if (MessageBox.Show(sb.ToString(), "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    DataTable insertdt = CargoinfoOperate.insertCargoinfo(data);
                    if (insertdt.HasErrors)
                    {
                        tssStatus.Text = "添加货物信息失败,已反馈服务器，请稍后重试。";
                        time.Start();
                        Errorinfo.errorPost("货物不存在，选择添加数据操作失败。");
                        return;
                    }
                    
                    DataTable waredt = WarehousingOperate.insertWareHousing(warehousingdata);
                    if (waredt.HasErrors)
                    {
                        tssStatus.Text = "入库信息添加失败，已反馈服务器，请稍后重试。";
                        time.Start();
                        Errorinfo.errorPost("入库信息添加失败。");
                    }

                    tssStatus.Text = "添加数据成功。";
                    time.Start();
                }
                return;
            }
                DataTable updatedt = CargoinfoOperate.updateCargoinfo(data);
                if (updatedt.HasErrors)
                {
                    tssStatus.Text = "更新货物信息失败，已反馈服务器，请稍后重试。";
                    time.Start();
                    Errorinfo.errorPost("货物存在，选择更新货物信息操作失败。");
                }

                DataTable waresdt = WarehousingOperate.insertWareHousing(warehousingdata);
                if (waresdt.HasErrors)
                {
                    tssStatus.Text = "入库信息添加失败，已反馈服务器，请稍后重试。";
                    time.Start();
                    Errorinfo.errorPost("入库信息添加失败。");
                }

                tssStatus.Text = "更新数据成功。";
                time.Start();
            nNum.Value = 0;

            dt = CargoinfoOperate.selectCargoinfo(cbbName.Text);//重新加载
            cbbModal_SelectedValueChanged(sender, e);//重新加载
        }
        /// <summary>
        /// 扫描枪扫描数据录入SN码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSnid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((CargoinfoOperate.selectCargoinfo(txtCargoid.Text)).Rows.Count<=0)
                {
                    rtbRecord.Text += "\n请在货物信息中选择添加SN码的货物信息。";
                    txtSnid.Text = string.Empty;
                    txtSnid.Focus();
                    return;
                }

                if (SerialOperate.selectSerial(cbbModal.SelectedValue.ToString(), txtSnid.Text) == 0)
                {
                    if (SerialOperate.insertSerial(cbbModal.SelectedValue.ToString(), txtSnid.Text, "").HasErrors)
                    {
                        rtbRecord.Text += "\n添加失败，已反馈服务器，请稍后重试。";
                        txtSnid.Text = string.Empty;
                        txtSnid.Focus();
                        return;
                    }
                    rtbRecord.Text += "\n添加成功，货物编号：" + cbbModal.SelectedValue.ToString() + ",SN码：" + txtSnid.Text + "。";
                    txtSnid.Text = string.Empty;
                    txtSnid.Focus();
                }
                else
                {
                    tssStatus.Text = "该序列号已存在，请核实后重新输入。";
                    time.Start();
                    txtSnid.SelectAll();
                    return;
                }
            }
        }
        /// <summary>
        /// 一直处于最下端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbRecord_TextChanged(object sender, EventArgs e)
        {
            rtbRecord.SelectionStart = rtbRecord.Text.Length;
            rtbRecord.SelectionLength = 0;
            rtbRecord.Focus();
        }
    }
}
