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
using System.IO;
using System.Data.OleDb;

namespace AdvtechManagementSystem
{
    public partial class frmStock : Form
    {
        DataTable dt = CargoinfoOperate.selectCargoinfoPage(0,50);
        Timer time = new Timer();
        int num = 1;
        int start = 0;
        int end = 50;
        public frmStock()
        {
            InitializeComponent();
            time.Interval = 1000;
            time.Tick += new EventHandler(TimerMessage);
        }
        /// <summary>
        /// 查询库存信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tstxtStock.Text.Trim()))
            {
                DataTable dtAll = CargoinfoOperate.selectCargoinfo();
                if (dtAll.HasErrors)
                {
                    Errorinfo.errorPost("查询库存信息失败。");
                    tslStatus.Text = "查询库存信息失败，已反馈服务器，请稍后重试";
                    time.Start();
                }
                LoadCargoinfo(dtAll);
                if (dtAll.Rows.Count != 0)
                {
                    llUp.Enabled = false;
                    lPageNumber.Text = 1 + "/" + Math.Ceiling((double)dtAll.Rows.Count / 5);
                }
                else
                {
                    llUp.Enabled = false;
                    llDown.Enabled = false;
                    lPageNumber.Text = "0/0";
                }
                return;
            }
            string selecttext = tstxtStock.Text;//获取查询内容
            DataTable dt = CargoinfoOperate.selectCargoinfo(selecttext);
            if (dt.HasErrors)
            {
                Errorinfo.errorPost("查询库存信息失败。");
                tslStatus.Text = "查询库存信息失败，已反馈服务器，请稍后重试";
                time.Start();
            }
            LoadCargoinfo(dt);
            lPageNumber.Text = "1/1";
            llUp.Enabled = false;
            llDown.Enabled = false;
            #region 详细库存操作
            //try
            //{
            //    Dictionary<string, string> dictionarystock = new Dictionary<string, string>();
            //    foreach (DataRow item in dt.Rows)
            //    {
            //        dictionarystock.Add(item["cargoid"].ToString(), item["cargoname"].ToString() + "(" + item["cargomodal"].ToString() + ")");
            //    }
            //    BindingSource bs = new BindingSource();
            //    bs.DataSource = dictionarystock;
            //    lbStock.ValueMember = "Key";
            //    lbStock.DisplayMember = "Value";
            //    lbStock.DataSource = bs;

            //    tslStatus.Text = "查询库存信息成功。";
            //    time.Start();
            //}
            //catch (Exception ex)
            //{
            //    Errorinfo.errorPost("查询库存失败，详细错误信息如下：" + ex.Message);
            //    tslStatus.Text = "查询库存信息失败，已反馈服务器，请稍后重试";
            //    time.Start();
            //}
            #endregion
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
        /// 当控件成为活动控件时清空内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstxtStock_Enter(object sender, EventArgs e)
        {
            tstxtStock.Text = string.Empty;
        }
        /// <summary>
        /// 按下回车时进行查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) tsbSelect_Click(sender, e);
        }
        /// <summary>
        /// 默认加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStock_Load(object sender, EventArgs e)
        {
            if (dt.HasErrors)
            {
                Errorinfo.errorPost("查询库存信息失败。");
                tslStatus.Text = "查询库存页信息失败，已反馈服务器，请稍后重试";
                time.Start();
            }
            LoadCargoinfo(dt);
            if (dt.Rows.Count != 0)
            {
                llUp.Enabled = false;
                DataTable dtAll = CargoinfoOperate.selectCargoinfo();
                lPageNumber.Text = 1 + "/" + Math.Ceiling((double)dtAll.Rows.Count / 5);
            }
            else
            {
                llUp.Enabled = false;
                llDown.Enabled = false;
                lPageNumber.Text = "0/0";
            }
            #region 详细操作内容
            //try
            //{
            //    Dictionary<string, string> dictionarystock = new Dictionary<string, string>();
            //    foreach (DataRow item in dt.Rows)
            //    {
            //        dictionarystock.Add(item["cargoid"].ToString(), item["cargoname"].ToString() + "(" + item["cargomodal"].ToString() + ")");
            //    }
            //    BindingSource bs = new BindingSource();
            //    bs.DataSource = dictionarystock;
            //    lbStock.ValueMember = "Key";
            //    lbStock.DisplayMember = "Value";
            //    lbStock.DataSource = bs;

            //    tslStatus.Text = "查询库存信息成功。";
            //    time.Start();
            //}
            //catch (Exception ex)
            //{
            //    Errorinfo.errorPost("查询库存失败，详细错误信息如下：" + ex.Message);
            //    tslStatus.Text = "查询库存信息失败，已反馈服务器，请稍后重试";
            //    time.Start();
            //}
            #endregion
        }
        /// <summary>
        /// 货物信息加载事件
        /// </summary>
        /// <param name="dtLoad"></param>
        private void LoadCargoinfo(DataTable dtLoad)
        {
            DataTable dt = dtLoad;
            try
            {
                Dictionary<string, string> dictionarystock = new Dictionary<string, string>();
                if (dt.Rows.Count == 0)
                    dictionarystock.Add("null", "暂无该库存信息");
                else
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        dictionarystock.Add(item["cargoid"].ToString(), item["cargoname"].ToString() + "(" + item["cargomodal"].ToString() + ")");
                    }
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = dictionarystock;
                lbStock.ValueMember = "Key";
                lbStock.DisplayMember = "Value";
                lbStock.DataSource = bs;

                tslStatus.Text = "查询库存信息成功。";
                time.Start();
            }
            catch (Exception ex)
            {
                Errorinfo.errorPost("查询库存失败，详细错误信息如下：" + ex.Message);
                tslStatus.Text = "查询库存信息失败，已反馈服务器，请稍后重试";
                time.Start();
            }
        }
        /// <summary>
        /// Excel导入库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbInStock_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel文件（*.xls,*.xlsx）|*.xls;*.xlsx";
                DataTable importdt = new DataTable(); ;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string excelname = ofd.FileName;
                    //importdt = NPOIHelper.ImportExceltoDt(excelname,"Sheet1",-1);
                    importdt = NPOIHelper.ExcelToTable(excelname);//默认有标题
                }
                if (importdt.Rows.Count!=9)
                {
                    MessageBox.Show("格式不正确，请核实之后重新输入。");
                    return;
                }
                foreach (DataRow item in importdt.Rows)
                {
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    data.Add("cargoid", item[0].ToString());
                    data.Add("cargoname", item[1].ToString());
                    data.Add("cargomodal", item[2].ToString());
                    data.Add("cargoamount", item[3].ToString());
                    data.Add("cargopurchase", item[4].ToString());
                    data.Add("cargosale", item[5].ToString());
                    data.Add("cargoware", item[6].ToString());
                    data.Add("cargounit", item[7].ToString());
                    data.Add("cargoremark", item[8].ToString());
                    if(CargoinfoOperate.insertCargoinfo(data).HasErrors)
                    {
                        MessageBox.Show("导入错误，已反馈服务器，请稍后再试");
                        return;
                    }
                    MessageBox.Show("导入成功！","系统提示");
                    tslStatus.Text = "导入成功。";
                    time.Start();

                    LoadCargoinfo(dt);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("错误信息：" + ex.Message), "系统提示");
                Errorinfo.errorPost("导入错误，错误内容如下：" + ex.Message);
                tslStatus.Text = "导入错误，已反馈到服务器，请稍后重试。";
                time.Start();
            }
            
        }
        /// <summary>
        /// Excel导出库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbOutStock_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter= "Excel文件(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
                if (sfd.ShowDialog()==DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    DataTable Alldt = CargoinfoOperate.selectCargoinfo();
                    NPOIHelper.TableToExcel(Alldt,filePath);

                    MessageBox.Show("导出成功！", "系统提示");
                    tslStatus.Text = "导出成功。";
                    time.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("错误信息：" + ex.Message), "系统提示");
                Errorinfo.errorPost("导出错误，错误内容如下：" + ex.Message);
                tslStatus.Text = "导出错误，已反馈到服务器，请稍后重试。";
                time.Start();
            }
        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] num = lPageNumber.Text.Split('/');
            if (Convert.ToInt32(num[0])-1==0|| Convert.ToInt32(num[0]) - 1 == 1)llUp.Enabled = false;
            llDown.Enabled = true;
            int page = Convert.ToInt32(num[0]);
            int nowpage = page-1;
            lPageNumber.Text = nowpage + "/" + num[1];
            end = start;
            start -= 50;
            LoadCargoinfo(CargoinfoOperate.selectCargoinfoPage(start, end));
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llDown_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] num = lPageNumber.Text.Split('/');
            if (Convert.ToInt32(num[0])+1==Convert.ToInt32(num[1]))llDown.Enabled = false;
            llUp.Enabled = true;
            int page = Convert.ToInt32(num[0]);
            int nowpage = page+1;
            lPageNumber.Text = nowpage + "/" + num[1];
            start = end;
            end += 50;
            LoadCargoinfo(CargoinfoOperate.selectCargoinfoPage(start, end));
        }
        /// <summary>
        /// 点击时显示详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbStock_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbStock.SelectedValue == null) return;
            if (lbStock.SelectedValue.ToString() == "null")
            {
                txtStockName.Text = string.Empty;
                txtStockModal.Text = string.Empty;
                return;
            }
            //SN码的名称型号显示
            gbSNID.Tag = lbStock.SelectedValue;
            string[] namemodal = lbStock.Text.Split('(');
            txtStockName.Text = namemodal[0];
            txtStockModal.Text = namemodal[1].Substring(0,namemodal[1].Length- 1);
            //显示详细的信息
            DataTable dt = CargoinfoOperate.selectCargoinfo(lbStock.SelectedValue.ToString());
            StringBuilder sb = new StringBuilder();
            if (dt.Rows.Count == 0) return;
            foreach (DataRow item in dt.Rows)
            {
                sb.AppendLine("销售商编号：" + item["customid"].ToString());
                sb.AppendLine("销售商名称：" + item["customname"].ToString());
                sb.AppendLine("销售商负责人：" + item["custompeople"].ToString());
                sb.AppendLine("销售商电话：" + item["customcontact"].ToString());
                sb.AppendLine("销售商公司地址：" + item["customaddress"].ToString());
                sb.AppendLine("销售商备注：" + item["customremark"].ToString());
                sb.AppendLine("销售商状态：" + item["customstatus"].ToString());
            }
                rtbStock.Text = sb.ToString();
        }
        /// <summary>
        /// 双击显示详细信息修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbStock_DoubleClick(object sender, EventArgs e)
        {
            if (lbStock.SelectedValue == null) return;
            DataTable dt = CargoinfoOperate.selectCargoinfo(lbStock.SelectedValue.ToString());
            if (dt.Rows.Count == 0) return;
            gbStock.Tag = dt.Rows[0]["cargoid"];
            txtName.Text=dt.Rows[0]["cargoname"].ToString();
            txtModal.Text = dt.Rows[0]["cargomodal"].ToString();
            nNum.Value = Convert.ToDecimal(dt.Rows[0]["cargoamount"]);
            txtPurchase.Text = dt.Rows[0]["cargopurchase"].ToString();
            txtSale.Text = dt.Rows[0]["cargosale"].ToString();
            cbbWare.Text = dt.Rows[0]["cargoware"].ToString();
            cbbUnit.Text = dt.Rows[0]["cargounit"].ToString();
            rtbRemark.Text = dt.Rows[0]["cargoremark"].ToString();
        }
        /// <summary>
        /// 提交库存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gbStock.Tag==null)
            {
                MessageBox.Show("请双击选择货物信息。", "系统提示");
                return;
            }
            //修改提交

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("@cargoid", gbStock.Tag.ToString());
            data.Add("cargoname", txtName.Text);
            data.Add("cargomodal", txtModal.Text);
            data.Add("cargoamount", nNum.Value.ToString());
            data.Add("cargopurchase", txtPurchase.Text);
            data.Add("cargosale", txtSale.Text);
            data.Add("cargoware", cbbWare.Text);
            data.Add("cargounit", cbbUnit.Text);
            data.Add("cargoremark", rtbRemark.Text);
            DataTable dts = CargoinfoOperate.insertCargoinfo(data);
            if (dts.HasErrors)
            {
                Errorinfo.errorPost("提交数据失败，提交内容——编号：" + gbStock.Tag.ToString() + "，名称：" + txtName.Text + ",型号：" + txtModal.Text);
                tslStatus.Text = "提交失败";
                time.Start();
                return;
            }
            MessageBox.Show("提交成功！", "系统提示");
            tslStatus.Text = "提交数据成功。";
            time.Start();

            LoadCargoinfo(dt);
        }
        /// <summary>
        /// SN码导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSNIn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel文件（*.xls,*.xlsx）|*.xls;*.xlsx";
                DataTable importdt = new DataTable(); ;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string excelname = ofd.FileName;
                    //importdt = NPOIHelper.ImportExceltoDt(excelname,"Sheet1",-1);
                    importdt = NPOIHelper.ExcelToTable(excelname);//默认有标题
                }
                foreach (DataRow item in importdt.Rows)
                {
                    lbSNOut.Items.Add(item[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("错误信息：" + ex.Message), "系统提示");
                Errorinfo.errorPost("导入错误，错误内容如下：" + ex.Message);
                tslStatus.Text = "导入错误，已反馈到服务器，请稍后重试。";
                time.Start();
            }
        }
        /// <summary>
        /// SN码导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSNOut_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel文件(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    DataTable Alldt = OtherOperate.selectSerial(gbSNID.Tag==null?null:gbSNID.Tag.ToString());
                    NPOIHelper.TableToExcel(Alldt, filePath);

                    MessageBox.Show("导出成功！", "系统提示");
                    tslStatus.Text = "导出成功。";
                    time.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("错误信息：" + ex.Message), "系统提示");
                Errorinfo.errorPost("导出错误，错误内容如下：" + ex.Message);
                tslStatus.Text = "导出错误，已反馈到服务器，请稍后重试。";
                time.Start();
            }
        }
        /// <summary>
        /// SN码保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSNSave_Click(object sender, EventArgs e)
        {
            if (lbSNOut.Items.Count == 0)
            {
                MessageBox.Show("请添加数据。");
                return;
            }
            foreach (string item in lbSNOut.Items)
            {
                string serid = gbSNID.Tag.ToString();
                if (SerialOperate.insertSerial(serid, item, "").HasErrors)
                {
                    MessageBox.Show(String.Format("SN码导入错误。SN码："+item), "系统提示");
                    tslStatus.Text = "SN码导入错误。SN码：" + item;
                    time.Start();
                    return;
                }
                lbSNIn.Items.Add(item);
                lbSNOut.Items.Remove(item);
            }

        }
        /// <summary>
        /// 输入回车进行SN码保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                lbSNOut.Items.Add(txtSNID.Text);
                txtSNID.Text = string.Empty;
            }
        }
    }
}
