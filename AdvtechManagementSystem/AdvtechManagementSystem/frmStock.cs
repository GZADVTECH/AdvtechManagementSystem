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
        DataTable dt = CargoinfoOperate.selectCargoinfoPage(0,10);
        Timer time = new Timer();
        int num = 1;
        int start = 0;
        int end = 30;
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
            string selecttext = tstxtStock.Text;//获取查询内容
            DataTable dt = CargoinfoOperate.selectCargoinfo(selecttext);
            if (dt.HasErrors)
            {
                Errorinfo.errorPost("查询库存信息失败。");
                tslStatus.Text = "查询库存信息失败，已反馈服务器，请稍后重试";
                time.Start();
            }
            LoadCargoinfo(dt);

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
            OpenFileDialog ofd = new OpenFileDialog();//首先根据打开文件对话框，选择excel表格
            ofd.Filter = "表格|*.xlsx";//打开文件对话框筛选器
            string strPath;//文件完整的路径名
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    strPath = ofd.FileName;
                    //microsoft.jet.oledb.4.0;Excel 97-2003
                    //Microsoft.ACE.OLEDB.12.0 Excel 2010
                    string strCon = "provider=Microsoft.ACE.OLEDB.12.0;data source=" + strPath + ";extended properties=excel 8.0";//关键是红色区域
                    OleDbConnection Con = new OleDbConnection(strCon);//建立连接
                    string strSql = "select * from [Sheet1$]";//表名的写法也应注意不同，对应的excel表为sheet1，在这里要在其后加美元符号$，并用中括号
                    OleDbCommand Cmd = new OleDbCommand(strSql, Con);//建立要执行的命令
                    OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//建立数据适配器
                    DataSet ds = new DataSet();//新建数据集
                    da.Fill(ds, "Sheet1");//把数据适配器中的数据读到数据集中的一个表中（此处表名为shyman，可以任取表名）
                    //指定datagridview1的数据源为数据集ds的第一张表（也就是shyman表），也可以写ds.Table["shyman"]
                    DataTable exportdt = ds.Tables[0];

                    //将导入的数据添加到数据库中
                    foreach (DataRow item in exportdt.Rows)
                    {
                        MessageBox.Show(item[1].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Errorinfo.errorPost("表格导入错误，错误信息如下："+ex.Message);//捕捉异常
                    tslStatus.Text = "表格导入失败，已反馈服务器，请稍后再试！";
                    time.Start();
                }
            }
        }
        /// <summary>
        /// Excel导出库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbOutStock_Click(object sender, EventArgs e)
        {

        }
    }
}
