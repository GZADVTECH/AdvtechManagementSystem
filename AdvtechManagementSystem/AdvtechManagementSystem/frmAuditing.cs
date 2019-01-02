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
    public partial class frmAuditing : Form
    {
        public frmAuditing()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 默认加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAuditing_Load(object sender, EventArgs e)
        {
            DataTable dt = OtherOperate.selectAuditing();
            dgvAuditing.DataSource = dt;
            dgvAuditing.AutoGenerateColumns = false;//不自动生成列
        }
    }
}
