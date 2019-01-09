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
    public partial class frmPurchase : Form
    {
        public frmPurchase()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// 窗体关闭后关闭整个程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 采购订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPurchase_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.MdiParent = this;
            order.Show();
        }
        /// <summary>
        /// 供应商管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier supplier = new frmSupplier();
            supplier.MdiParent = this;
            supplier.Show();
        }
        /// <summary>
        /// 库存情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSituation_Click(object sender, EventArgs e)
        {
            frmSituation situation = new frmSituation();
            situation.MdiParent = this;
            situation.Show();
        }
        /// <summary>
        /// 审核情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAuditing_Click(object sender, EventArgs e)
        {
            frmAuditing auditing = new frmAuditing();
            auditing.MdiParent = this;
            auditing.Show();
        }
    }
}
