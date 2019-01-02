namespace AdvtechManagementSystem
{
    partial class frmSituation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSituation));
            this.tsSituation = new System.Windows.Forms.ToolStrip();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tslStock = new System.Windows.Forms.ToolStripLabel();
            this.tstxtStock = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvSituation = new System.Windows.Forms.DataGridView();
            this.cCargoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargoname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargomodal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargoamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargopurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargosale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargoware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargounit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargotime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargoremark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccargostatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsSituation.SuspendLayout();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSituation)).BeginInit();
            this.SuspendLayout();
            // 
            // tsSituation
            // 
            this.tsSituation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStock,
            this.tstxtStock,
            this.tsbSelect});
            this.tsSituation.Location = new System.Drawing.Point(0, 0);
            this.tsSituation.Name = "tsSituation";
            this.tsSituation.Size = new System.Drawing.Size(793, 25);
            this.tsSituation.TabIndex = 0;
            this.tsSituation.Text = "toolStrip1";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 555);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(793, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tslStock
            // 
            this.tslStock.Name = "tslStock";
            this.tslStock.Size = new System.Drawing.Size(68, 22);
            this.tslStock.Text = "快速查询：";
            // 
            // tstxtStock
            // 
            this.tstxtStock.Name = "tstxtStock";
            this.tstxtStock.Size = new System.Drawing.Size(150, 25);
            // 
            // tsbSelect
            // 
            this.tsbSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(23, 22);
            this.tsbSelect.Text = "输入关键字进行查询";
            this.tsbSelect.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(92, 17);
            this.tslStatus.Text = "操作反馈。。。";
            // 
            // dgvSituation
            // 
            this.dgvSituation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSituation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCargoid,
            this.cCargoname,
            this.cCargomodal,
            this.cCargoamount,
            this.cCargopurchase,
            this.cCargosale,
            this.cCargoware,
            this.cCargounit,
            this.cCargotime,
            this.cCargoremark,
            this.ccargostatus});
            this.dgvSituation.Location = new System.Drawing.Point(12, 28);
            this.dgvSituation.Name = "dgvSituation";
            this.dgvSituation.RowTemplate.Height = 23;
            this.dgvSituation.Size = new System.Drawing.Size(769, 524);
            this.dgvSituation.TabIndex = 2;
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
            // cCargosale
            // 
            this.cCargosale.DataPropertyName = "cargosale";
            this.cCargosale.HeaderText = "销售价格";
            this.cCargosale.Name = "cCargosale";
            this.cCargosale.ReadOnly = true;
            // 
            // cCargoware
            // 
            this.cCargoware.DataPropertyName = "cargoware";
            this.cCargoware.HeaderText = "仓库位置";
            this.cCargoware.Name = "cCargoware";
            this.cCargoware.ReadOnly = true;
            // 
            // cCargounit
            // 
            this.cCargounit.DataPropertyName = "cargounit";
            this.cCargounit.HeaderText = "存放单位";
            this.cCargounit.Name = "cCargounit";
            this.cCargounit.ReadOnly = true;
            // 
            // cCargotime
            // 
            this.cCargotime.DataPropertyName = "cargotime";
            this.cCargotime.HeaderText = "添加时间";
            this.cCargotime.Name = "cCargotime";
            this.cCargotime.ReadOnly = true;
            this.cCargotime.Visible = false;
            // 
            // cCargoremark
            // 
            this.cCargoremark.DataPropertyName = "cargoremark";
            this.cCargoremark.HeaderText = "备注";
            this.cCargoremark.Name = "cCargoremark";
            this.cCargoremark.ReadOnly = true;
            this.cCargoremark.Visible = false;
            // 
            // ccargostatus
            // 
            this.ccargostatus.DataPropertyName = "cargostatus";
            this.ccargostatus.HeaderText = "状态";
            this.ccargostatus.Name = "ccargostatus";
            this.ccargostatus.ReadOnly = true;
            this.ccargostatus.Visible = false;
            // 
            // frmSituation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 577);
            this.Controls.Add(this.dgvSituation);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tsSituation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSituation";
            this.Text = "库存情况";
            this.Load += new System.EventHandler(this.frmSituation_Load);
            this.tsSituation.ResumeLayout(false);
            this.tsSituation.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSituation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSituation;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripLabel tslStock;
        private System.Windows.Forms.ToolStripTextBox tstxtStock;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.DataGridView dgvSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargoname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargomodal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargoamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargopurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargosale;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargoware;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargounit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargotime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargoremark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccargostatus;
    }
}