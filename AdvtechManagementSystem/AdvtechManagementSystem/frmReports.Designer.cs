namespace AdvtechManagementSystem
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMonth = new System.Windows.Forms.DataGridView();
            this.cCargoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargoname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargomodal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargoamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargopurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cWare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当月库存情况";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "导出到Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMonth
            // 
            this.dgvMonth.AllowUserToAddRows = false;
            this.dgvMonth.AllowUserToDeleteRows = false;
            this.dgvMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCargoid,
            this.cCargoname,
            this.cCargomodal,
            this.cCargoamount,
            this.cCargopurchase,
            this.cSale,
            this.cWare,
            this.cUnit,
            this.cTime,
            this.cRemark});
            this.dgvMonth.Location = new System.Drawing.Point(13, 41);
            this.dgvMonth.Name = "dgvMonth";
            this.dgvMonth.ReadOnly = true;
            this.dgvMonth.RowTemplate.Height = 23;
            this.dgvMonth.Size = new System.Drawing.Size(981, 664);
            this.dgvMonth.TabIndex = 2;
            // 
            // cCargoid
            // 
            this.cCargoid.DataPropertyName = "cargoid";
            this.cCargoid.HeaderText = "货物编号";
            this.cCargoid.Name = "cCargoid";
            this.cCargoid.ReadOnly = true;
            // 
            // cCargoname
            // 
            this.cCargoname.DataPropertyName = "cargoname";
            this.cCargoname.HeaderText = "货物名称";
            this.cCargoname.Name = "cCargoname";
            this.cCargoname.ReadOnly = true;
            // 
            // cCargomodal
            // 
            this.cCargomodal.DataPropertyName = "cargomodal";
            this.cCargomodal.HeaderText = "货物型号";
            this.cCargomodal.Name = "cCargomodal";
            this.cCargomodal.ReadOnly = true;
            // 
            // cCargoamount
            // 
            this.cCargoamount.DataPropertyName = "cargoamount";
            this.cCargoamount.HeaderText = "库存数量";
            this.cCargoamount.Name = "cCargoamount";
            this.cCargoamount.ReadOnly = true;
            // 
            // cCargopurchase
            // 
            this.cCargopurchase.DataPropertyName = "cargopurchase";
            this.cCargopurchase.HeaderText = "采购价格";
            this.cCargopurchase.Name = "cCargopurchase";
            this.cCargopurchase.ReadOnly = true;
            // 
            // cSale
            // 
            this.cSale.DataPropertyName = "cargosale";
            this.cSale.HeaderText = "销售价格";
            this.cSale.Name = "cSale";
            this.cSale.ReadOnly = true;
            // 
            // cWare
            // 
            this.cWare.DataPropertyName = "cargoware";
            this.cWare.HeaderText = "仓库位置";
            this.cWare.Name = "cWare";
            this.cWare.ReadOnly = true;
            // 
            // cUnit
            // 
            this.cUnit.DataPropertyName = "cargounit";
            this.cUnit.HeaderText = "仓库单位";
            this.cUnit.Name = "cUnit";
            this.cUnit.ReadOnly = true;
            // 
            // cTime
            // 
            this.cTime.DataPropertyName = "cargotime";
            this.cTime.HeaderText = "最后更新时间";
            this.cTime.Name = "cTime";
            this.cTime.ReadOnly = true;
            // 
            // cRemark
            // 
            this.cRemark.DataPropertyName = "cargoremark";
            this.cRemark.HeaderText = "备注";
            this.cRemark.Name = "cRemark";
            this.cRemark.ReadOnly = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 717);
            this.Controls.Add(this.dgvMonth);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReports";
            this.Text = "报表查看";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargoname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargomodal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargoamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargopurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn cWare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemark;
    }
}