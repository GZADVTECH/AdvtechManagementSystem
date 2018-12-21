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
    }
}
