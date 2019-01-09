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
    public partial class frmSituation : Form
    {
        DataTable dt = CargoinfoOperate.selectCargoinfo();
        Timer time = new Timer();
        int num = 1;
        public frmSituation()
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
        private void frmSituation_Load(object sender, EventArgs e)
        {
            if (dt.HasErrors)
            {
                Errorinfo.errorPost("加载库存情况信息失败。");
                tslStatus.Text = "加载库存情况信息失败，已反馈服务器，请稍后重试。";
                time.Start();
                return;
            }
            dgvSituation.DataSource = dt;
            dgvSituation.AutoGenerateColumns = false;
            tslStatus.Text = "库存信息加载成功。";
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
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            string selecttext = tstxtStock.Text;//获取查询内容
            DataTable dt = CargoinfoOperate.selectCargoinfo(selecttext);
            if (dt.HasErrors)
            {
                Errorinfo.errorPost("查询库存信息失败。");
                tslStatus.Text = "查询库存信息失败，已反馈服务器，请稍后重试";
                time.Start();
                return;
            }
            dgvSituation.DataSource = dt;
            tslStatus.Text = "条件查询库存信息成功。";
            time.Start();
            tstxtStock.Text = string.Empty;
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
    }
}
