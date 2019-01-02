namespace AdvtechManagementSystem
{
    partial class frmAuditing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditing));
            this.dgvAuditing = new System.Windows.Forms.DataGridView();
            this.cAudid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAudpurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAuduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAudstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditing)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuditing
            // 
            this.dgvAuditing.AllowUserToAddRows = false;
            this.dgvAuditing.AllowUserToDeleteRows = false;
            this.dgvAuditing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAudid,
            this.cAudpurchase,
            this.cAuduser,
            this.cAudstatus,
            this.cRemark});
            this.dgvAuditing.Location = new System.Drawing.Point(13, 13);
            this.dgvAuditing.Name = "dgvAuditing";
            this.dgvAuditing.ReadOnly = true;
            this.dgvAuditing.RowTemplate.Height = 23;
            this.dgvAuditing.Size = new System.Drawing.Size(601, 522);
            this.dgvAuditing.TabIndex = 0;
            // 
            // cAudid
            // 
            this.cAudid.DataPropertyName = "audid";
            this.cAudid.HeaderText = "审核编号";
            this.cAudid.Name = "cAudid";
            this.cAudid.ReadOnly = true;
            // 
            // cAudpurchase
            // 
            this.cAudpurchase.DataPropertyName = "audpurchase";
            this.cAudpurchase.HeaderText = "审核采购订单号";
            this.cAudpurchase.Name = "cAudpurchase";
            this.cAudpurchase.ReadOnly = true;
            this.cAudpurchase.Width = 200;
            // 
            // cAuduser
            // 
            this.cAuduser.DataPropertyName = "auduser";
            this.cAuduser.HeaderText = "员工编号";
            this.cAuduser.Name = "cAuduser";
            this.cAuduser.ReadOnly = true;
            this.cAuduser.Visible = false;
            // 
            // cAudstatus
            // 
            this.cAudstatus.DataPropertyName = "audstatus";
            this.cAudstatus.HeaderText = "通过状态";
            this.cAudstatus.Name = "cAudstatus";
            this.cAudstatus.ReadOnly = true;
            this.cAudstatus.Width = 150;
            // 
            // cRemark
            // 
            this.cRemark.DataPropertyName = "audremark";
            this.cRemark.HeaderText = "备注";
            this.cRemark.Name = "cRemark";
            this.cRemark.ReadOnly = true;
            // 
            // frmAuditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 547);
            this.Controls.Add(this.dgvAuditing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAuditing";
            this.Text = "审核情况";
            this.Load += new System.EventHandler(this.frmAuditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditing;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAudid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAudpurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAuduser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAudstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemark;
    }
}