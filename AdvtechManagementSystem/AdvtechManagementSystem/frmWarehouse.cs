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
    public partial class frmWarehouse : Form
    {
        public frmWarehouse()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// 窗体关闭时关闭整个程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWarehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 库存管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbStock_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            stock.MdiParent = this;
            stock.Show();
        }
        /// <summary>
        /// 入库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbIn_Click(object sender, EventArgs e)
        {
            frmWareIn warein = new frmWareIn();
            warein.MdiParent = this;
            warein.Show();
        }
        /// <summary>
        /// 出库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbOut_Click(object sender, EventArgs e)
        {
            frmWareOut wareout = new frmWareOut();
            wareout.MdiParent = this;
            wareout.Show();
        }
    }
}
