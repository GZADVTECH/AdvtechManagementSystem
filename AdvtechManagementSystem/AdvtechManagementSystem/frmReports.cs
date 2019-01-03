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
            DataTable dt = OtherOperate.selectmonthcargoinfo();
            dgvMonth.DataSource = dt;
        }
        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel文件(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    DataTable Alldt = OtherOperate.selectmonthcargoinfo();
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
    }
}
