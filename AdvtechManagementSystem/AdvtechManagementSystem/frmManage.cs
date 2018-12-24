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
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// 窗体关闭后关闭整个程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 用户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbUserinfo_Click(object sender, EventArgs e)
        {
            frmUsermanage usermanage = new frmUsermanage();
            usermanage.MdiParent = this;
            usermanage.Show();
        }
    }
}
