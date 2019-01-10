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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 默认加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReports_Load(object sender, EventArgs e)
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

            DataTable dt = OtherOperate.selectmonthcargoinfo(DateTime.Now);
            dgvMonth.DataSource = dt;

            DataTable dtser = OtherOperate.selectSerial(null);
            lbSer.ValueMember = "serid";
            lbSer.DisplayMember = "sersnid";
            lbSer.DataSource = dtser;

            DataTable serialrecord = OtherOperate.selectSerialrecord();
            dgvSer.DataSource = serialrecord;
        }

        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel文件(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    DataTable Alldt = OtherOperate.selectmonthcargoinfo(dtpTime.Value);
                    NPOIHelper.TableToExcel(Alldt, filePath);

                    MessageBox.Show("导出成功！", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("错误信息：" + ex.Message), "系统提示");
                Errorinfo.errorPost("导出错误，错误内容如下：" + ex.Message);
            }
        }
        /// <summary>
        /// 点击查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = OtherOperate.selectmonthcargoinfo(dtpTime.Value);
            dgvMonth.DataSource = dt;
        }

        private void cbbName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbName.SelectedValue == null)
            {
                cbbModal.DataSource = null;
                return;
            }

            DataTable dt = CargoinfoOperate.selectCargoinfo(cbbName.Text);
            if (dt.HasErrors)
            {
                Errorinfo.errorPost("查询产品型号错误。");
            }
            if (dt.Rows.Count <= 0)
            {
                cbbModal.DataSource = null;
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

        private void cbbModal_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbModal.SelectedValue == null) return;
            if (cbbModal.SelectedIndex < 0) return;
        }

        private void btnSnidSelect_Click(object sender, EventArgs e)
        {
            DataTable dtser = OtherOperate.selectSerial((cbbModal.SelectedValue==null)?null:cbbModal.SelectedValue.ToString());
            lbSer.ValueMember = "serid";
            lbSer.DisplayMember = "sersnid";
            lbSer.DataSource = dtser;
        }
    }
}
