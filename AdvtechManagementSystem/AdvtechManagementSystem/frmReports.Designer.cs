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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.lModal = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.cbbModal = new System.Windows.Forms.ComboBox();
            this.btnSnidSelect = new System.Windows.Forms.Button();
            this.lbSer = new System.Windows.Forms.ListBox();
            this.dgvSer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 693);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpTime);
            this.tabPage1.Controls.Add(this.dgvMonth);
            this.tabPage1.Controls.Add(this.btnSelect);
            this.tabPage1.Controls.Add(this.btnOut);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "月库存情况";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSer);
            this.tabPage2.Controls.Add(this.lbSer);
            this.tabPage2.Controls.Add(this.btnSnidSelect);
            this.tabPage2.Controls.Add(this.cbbModal);
            this.tabPage2.Controls.Add(this.cbbName);
            this.tabPage2.Controls.Add(this.lName);
            this.tabPage2.Controls.Add(this.lModal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "序列号查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "";
            this.dtpTime.Location = new System.Drawing.Point(6, 11);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 21);
            this.dtpTime.TabIndex = 8;
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
            this.dgvMonth.Location = new System.Drawing.Point(0, 39);
            this.dgvMonth.Name = "dgvMonth";
            this.dgvMonth.ReadOnly = true;
            this.dgvMonth.RowTemplate.Height = 23;
            this.dgvMonth.Size = new System.Drawing.Size(974, 628);
            this.dgvMonth.TabIndex = 7;
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
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(212, 11);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(84, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(859, 9);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(109, 23);
            this.btnOut.TabIndex = 6;
            this.btnOut.Text = "导出到Excel";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // lModal
            // 
            this.lModal.AutoSize = true;
            this.lModal.Location = new System.Drawing.Point(16, 37);
            this.lModal.Name = "lModal";
            this.lModal.Size = new System.Drawing.Size(41, 12);
            this.lModal.TabIndex = 18;
            this.lModal.Text = "型号：";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(16, 10);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(41, 12);
            this.lName.TabIndex = 19;
            this.lName.Text = "名称：";
            // 
            // cbbName
            // 
            this.cbbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(73, 7);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(180, 20);
            this.cbbName.TabIndex = 14;
            this.cbbName.SelectedValueChanged += new System.EventHandler(this.cbbName_SelectedValueChanged);
            // 
            // cbbModal
            // 
            this.cbbModal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbModal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbModal.FormattingEnabled = true;
            this.cbbModal.Location = new System.Drawing.Point(73, 33);
            this.cbbModal.Name = "cbbModal";
            this.cbbModal.Size = new System.Drawing.Size(180, 20);
            this.cbbModal.TabIndex = 15;
            this.cbbModal.SelectedValueChanged += new System.EventHandler(this.cbbModal_SelectedValueChanged);
            // 
            // btnSnidSelect
            // 
            this.btnSnidSelect.Location = new System.Drawing.Point(276, 20);
            this.btnSnidSelect.Name = "btnSnidSelect";
            this.btnSnidSelect.Size = new System.Drawing.Size(94, 23);
            this.btnSnidSelect.TabIndex = 20;
            this.btnSnidSelect.Text = "查询";
            this.btnSnidSelect.UseVisualStyleBackColor = true;
            this.btnSnidSelect.Click += new System.EventHandler(this.btnSnidSelect_Click);
            // 
            // lbSer
            // 
            this.lbSer.FormattingEnabled = true;
            this.lbSer.ItemHeight = 12;
            this.lbSer.Location = new System.Drawing.Point(18, 66);
            this.lbSer.Name = "lbSer";
            this.lbSer.Size = new System.Drawing.Size(352, 592);
            this.lbSer.TabIndex = 21;
            // 
            // dgvSer
            // 
            this.dgvSer.AllowUserToAddRows = false;
            this.dgvSer.AllowUserToDeleteRows = false;
            this.dgvSer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSer.Location = new System.Drawing.Point(410, 7);
            this.dgvSer.Name = "dgvSer";
            this.dgvSer.ReadOnly = true;
            this.dgvSer.RowTemplate.Height = 23;
            this.dgvSer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSer.Size = new System.Drawing.Size(558, 651);
            this.dgvSer.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "srserial";
            this.Column1.HeaderText = "序列号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "srstatus";
            this.Column2.HeaderText = "操作";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "srtime";
            this.Column3.HeaderText = "时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 215;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 717);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReports";
            this.Text = "报表查看";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpTime;
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
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSnidSelect;
        private System.Windows.Forms.ComboBox cbbModal;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lModal;
        private System.Windows.Forms.ListBox lbSer;
        private System.Windows.Forms.DataGridView dgvSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}