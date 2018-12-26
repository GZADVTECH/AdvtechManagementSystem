namespace AdvtechManagementSystem
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.tsStock = new System.Windows.Forms.ToolStrip();
            this.tslStock = new System.Windows.Forms.ToolStripLabel();
            this.tstxtStock = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tssStock = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInStock = new System.Windows.Forms.ToolStripButton();
            this.tsbOutStock = new System.Windows.Forms.ToolStripButton();
            this.lbStock = new System.Windows.Forms.ListBox();
            this.rtbStock = new System.Windows.Forms.RichTextBox();
            this.gbSNID = new System.Windows.Forms.GroupBox();
            this.btnSNSave = new System.Windows.Forms.Button();
            this.txtSNID = new System.Windows.Forms.TextBox();
            this.lSNOut = new System.Windows.Forms.Label();
            this.lSNIn = new System.Windows.Forms.Label();
            this.lbSNOut = new System.Windows.Forms.ListBox();
            this.lbSNIn = new System.Windows.Forms.ListBox();
            this.btnSNOut = new System.Windows.Forms.Button();
            this.btnSNIn = new System.Windows.Forms.Button();
            this.txtStockModal = new System.Windows.Forms.TextBox();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.lStockModal = new System.Windows.Forms.Label();
            this.lStockName = new System.Windows.Forms.Label();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.cbbUnit = new System.Windows.Forms.ComboBox();
            this.cbbWare = new System.Windows.Forms.ComboBox();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.nNum = new System.Windows.Forms.NumericUpDown();
            this.lRemark = new System.Windows.Forms.Label();
            this.lunit = new System.Windows.Forms.Label();
            this.lWare = new System.Windows.Forms.Label();
            this.txtModal = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lSale = new System.Windows.Forms.Label();
            this.lPurchase = new System.Windows.Forms.Label();
            this.lAmount = new System.Windows.Forms.Label();
            this.lModal = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.llUp = new System.Windows.Forms.LinkLabel();
            this.llDown = new System.Windows.Forms.LinkLabel();
            this.lPageNumber = new System.Windows.Forms.Label();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStock.SuspendLayout();
            this.gbSNID.SuspendLayout();
            this.gbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).BeginInit();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsStock
            // 
            this.tsStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStock,
            this.tstxtStock,
            this.tsbSelect,
            this.tssStock,
            this.tsbInStock,
            this.tsbOutStock});
            this.tsStock.Location = new System.Drawing.Point(0, 0);
            this.tsStock.Name = "tsStock";
            this.tsStock.Size = new System.Drawing.Size(773, 25);
            this.tsStock.TabIndex = 0;
            this.tsStock.Text = "toolStrip1";
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
            this.tstxtStock.Enter += new System.EventHandler(this.tstxtStock_Enter);
            this.tstxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstxtStock_KeyPress);
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
            // tssStock
            // 
            this.tssStock.Name = "tssStock";
            this.tssStock.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbInStock
            // 
            this.tsbInStock.Image = ((System.Drawing.Image)(resources.GetObject("tsbInStock.Image")));
            this.tsbInStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInStock.Name = "tsbInStock";
            this.tsbInStock.Size = new System.Drawing.Size(105, 22);
            this.tsbInStock.Text = "库存Excel导入";
            this.tsbInStock.Click += new System.EventHandler(this.tsbInStock_Click);
            // 
            // tsbOutStock
            // 
            this.tsbOutStock.Image = ((System.Drawing.Image)(resources.GetObject("tsbOutStock.Image")));
            this.tsbOutStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOutStock.Name = "tsbOutStock";
            this.tsbOutStock.Size = new System.Drawing.Size(105, 22);
            this.tsbOutStock.Text = "库存Excel导出";
            this.tsbOutStock.Click += new System.EventHandler(this.tsbOutStock_Click);
            // 
            // lbStock
            // 
            this.lbStock.FormattingEnabled = true;
            this.lbStock.ItemHeight = 12;
            this.lbStock.Location = new System.Drawing.Point(13, 29);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(221, 544);
            this.lbStock.TabIndex = 1;
            this.lbStock.SelectedValueChanged += new System.EventHandler(this.lbStock_SelectedValueChanged);
            this.lbStock.DoubleClick += new System.EventHandler(this.lbStock_DoubleClick);
            // 
            // rtbStock
            // 
            this.rtbStock.Location = new System.Drawing.Point(240, 29);
            this.rtbStock.Name = "rtbStock";
            this.rtbStock.ReadOnly = true;
            this.rtbStock.Size = new System.Drawing.Size(521, 115);
            this.rtbStock.TabIndex = 2;
            this.rtbStock.Text = "";
            // 
            // gbSNID
            // 
            this.gbSNID.Controls.Add(this.btnSNSave);
            this.gbSNID.Controls.Add(this.txtSNID);
            this.gbSNID.Controls.Add(this.lSNOut);
            this.gbSNID.Controls.Add(this.lSNIn);
            this.gbSNID.Controls.Add(this.lbSNOut);
            this.gbSNID.Controls.Add(this.lbSNIn);
            this.gbSNID.Controls.Add(this.btnSNOut);
            this.gbSNID.Controls.Add(this.btnSNIn);
            this.gbSNID.Controls.Add(this.txtStockModal);
            this.gbSNID.Controls.Add(this.txtStockName);
            this.gbSNID.Controls.Add(this.lStockModal);
            this.gbSNID.Controls.Add(this.lStockName);
            this.gbSNID.Location = new System.Drawing.Point(511, 151);
            this.gbSNID.Name = "gbSNID";
            this.gbSNID.Size = new System.Drawing.Size(250, 446);
            this.gbSNID.TabIndex = 3;
            this.gbSNID.TabStop = false;
            this.gbSNID.Text = "S/N码";
            // 
            // btnSNSave
            // 
            this.btnSNSave.Location = new System.Drawing.Point(87, 74);
            this.btnSNSave.Name = "btnSNSave";
            this.btnSNSave.Size = new System.Drawing.Size(75, 23);
            this.btnSNSave.TabIndex = 6;
            this.btnSNSave.Text = "保存";
            this.btnSNSave.UseVisualStyleBackColor = true;
            this.btnSNSave.Click += new System.EventHandler(this.btnSNSave_Click);
            // 
            // txtSNID
            // 
            this.txtSNID.Location = new System.Drawing.Point(6, 413);
            this.txtSNID.Name = "txtSNID";
            this.txtSNID.Size = new System.Drawing.Size(237, 21);
            this.txtSNID.TabIndex = 5;
            this.txtSNID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSNID_KeyPress);
            // 
            // lSNOut
            // 
            this.lSNOut.AutoSize = true;
            this.lSNOut.Location = new System.Drawing.Point(128, 112);
            this.lSNOut.Name = "lSNOut";
            this.lSNOut.Size = new System.Drawing.Size(119, 12);
            this.lSNOut.TabIndex = 4;
            this.lSNOut.Text = "正在进行操作的S/N码";
            // 
            // lSNIn
            // 
            this.lSNIn.AutoSize = true;
            this.lSNIn.Location = new System.Drawing.Point(4, 112);
            this.lSNIn.Name = "lSNIn";
            this.lSNIn.Size = new System.Drawing.Size(83, 12);
            this.lSNIn.TabIndex = 4;
            this.lSNIn.Text = "已保存的S/N码";
            // 
            // lbSNOut
            // 
            this.lbSNOut.FormattingEnabled = true;
            this.lbSNOut.ItemHeight = 12;
            this.lbSNOut.Location = new System.Drawing.Point(130, 127);
            this.lbSNOut.Name = "lbSNOut";
            this.lbSNOut.Size = new System.Drawing.Size(113, 268);
            this.lbSNOut.TabIndex = 3;
            // 
            // lbSNIn
            // 
            this.lbSNIn.FormattingEnabled = true;
            this.lbSNIn.ItemHeight = 12;
            this.lbSNIn.Location = new System.Drawing.Point(6, 127);
            this.lbSNIn.Name = "lbSNIn";
            this.lbSNIn.Size = new System.Drawing.Size(113, 268);
            this.lbSNIn.TabIndex = 3;
            // 
            // btnSNOut
            // 
            this.btnSNOut.Location = new System.Drawing.Point(168, 74);
            this.btnSNOut.Name = "btnSNOut";
            this.btnSNOut.Size = new System.Drawing.Size(75, 23);
            this.btnSNOut.TabIndex = 2;
            this.btnSNOut.Text = "Excel导出";
            this.btnSNOut.UseVisualStyleBackColor = true;
            this.btnSNOut.Click += new System.EventHandler(this.btnSNOut_Click);
            // 
            // btnSNIn
            // 
            this.btnSNIn.Location = new System.Drawing.Point(6, 74);
            this.btnSNIn.Name = "btnSNIn";
            this.btnSNIn.Size = new System.Drawing.Size(75, 23);
            this.btnSNIn.TabIndex = 2;
            this.btnSNIn.Text = "Excel导入";
            this.btnSNIn.UseVisualStyleBackColor = true;
            this.btnSNIn.Click += new System.EventHandler(this.btnSNIn_Click);
            // 
            // txtStockModal
            // 
            this.txtStockModal.Location = new System.Drawing.Point(60, 47);
            this.txtStockModal.Name = "txtStockModal";
            this.txtStockModal.ReadOnly = true;
            this.txtStockModal.Size = new System.Drawing.Size(183, 21);
            this.txtStockModal.TabIndex = 1;
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(60, 20);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.ReadOnly = true;
            this.txtStockName.Size = new System.Drawing.Size(183, 21);
            this.txtStockName.TabIndex = 1;
            // 
            // lStockModal
            // 
            this.lStockModal.AutoSize = true;
            this.lStockModal.Location = new System.Drawing.Point(13, 50);
            this.lStockModal.Name = "lStockModal";
            this.lStockModal.Size = new System.Drawing.Size(41, 12);
            this.lStockModal.TabIndex = 0;
            this.lStockModal.Text = "型号：";
            // 
            // lStockName
            // 
            this.lStockName.AutoSize = true;
            this.lStockName.Location = new System.Drawing.Point(13, 23);
            this.lStockName.Name = "lStockName";
            this.lStockName.Size = new System.Drawing.Size(41, 12);
            this.lStockName.TabIndex = 0;
            this.lStockName.Text = "名称：";
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.btnSave);
            this.gbStock.Controls.Add(this.rtbRemark);
            this.gbStock.Controls.Add(this.cbbUnit);
            this.gbStock.Controls.Add(this.cbbWare);
            this.gbStock.Controls.Add(this.txtSale);
            this.gbStock.Controls.Add(this.txtPurchase);
            this.gbStock.Controls.Add(this.nNum);
            this.gbStock.Controls.Add(this.lRemark);
            this.gbStock.Controls.Add(this.lunit);
            this.gbStock.Controls.Add(this.lWare);
            this.gbStock.Controls.Add(this.txtModal);
            this.gbStock.Controls.Add(this.txtName);
            this.gbStock.Controls.Add(this.lSale);
            this.gbStock.Controls.Add(this.lPurchase);
            this.gbStock.Controls.Add(this.lAmount);
            this.gbStock.Controls.Add(this.lModal);
            this.gbStock.Controls.Add(this.lName);
            this.gbStock.Location = new System.Drawing.Point(240, 151);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(265, 446);
            this.gbStock.TabIndex = 4;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "相关信息";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(79, 223);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(180, 176);
            this.rtbRemark.TabIndex = 8;
            this.rtbRemark.Text = "如需标注是否含税，请在此处填写（例:采购价格不含税，销售价格含税）";
            // 
            // cbbUnit
            // 
            this.cbbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUnit.FormattingEnabled = true;
            this.cbbUnit.Items.AddRange(new object[] {
            "个",
            "卷",
            "台",
            "套",
            "条",
            "位",
            "箱",
            "打"});
            this.cbbUnit.Location = new System.Drawing.Point(210, 188);
            this.cbbUnit.Name = "cbbUnit";
            this.cbbUnit.Size = new System.Drawing.Size(49, 20);
            this.cbbUnit.TabIndex = 7;
            // 
            // cbbWare
            // 
            this.cbbWare.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbWare.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbWare.FormattingEnabled = true;
            this.cbbWare.Items.AddRange(new object[] {
            "公司",
            "工厂",
            "仓库",
            "其他"});
            this.cbbWare.Location = new System.Drawing.Point(79, 188);
            this.cbbWare.Name = "cbbWare";
            this.cbbWare.Size = new System.Drawing.Size(78, 20);
            this.cbbWare.TabIndex = 6;
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(79, 154);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(180, 21);
            this.txtSale.TabIndex = 5;
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(79, 120);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(180, 21);
            this.txtPurchase.TabIndex = 4;
            // 
            // nNum
            // 
            this.nNum.Location = new System.Drawing.Point(79, 87);
            this.nNum.Name = "nNum";
            this.nNum.Size = new System.Drawing.Size(180, 21);
            this.nNum.TabIndex = 3;
            // 
            // lRemark
            // 
            this.lRemark.AutoSize = true;
            this.lRemark.Location = new System.Drawing.Point(7, 226);
            this.lRemark.Name = "lRemark";
            this.lRemark.Size = new System.Drawing.Size(41, 12);
            this.lRemark.TabIndex = 2;
            this.lRemark.Text = "备注：";
            // 
            // lunit
            // 
            this.lunit.AutoSize = true;
            this.lunit.Location = new System.Drawing.Point(163, 191);
            this.lunit.Name = "lunit";
            this.lunit.Size = new System.Drawing.Size(41, 12);
            this.lunit.TabIndex = 2;
            this.lunit.Text = "单位：";
            // 
            // lWare
            // 
            this.lWare.AutoSize = true;
            this.lWare.Location = new System.Drawing.Point(7, 191);
            this.lWare.Name = "lWare";
            this.lWare.Size = new System.Drawing.Size(65, 12);
            this.lWare.TabIndex = 2;
            this.lWare.Text = "存放位置：";
            // 
            // txtModal
            // 
            this.txtModal.Location = new System.Drawing.Point(79, 52);
            this.txtModal.Name = "txtModal";
            this.txtModal.ReadOnly = true;
            this.txtModal.Size = new System.Drawing.Size(180, 21);
            this.txtModal.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 18);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(180, 21);
            this.txtName.TabIndex = 1;
            // 
            // lSale
            // 
            this.lSale.AutoSize = true;
            this.lSale.Location = new System.Drawing.Point(7, 157);
            this.lSale.Name = "lSale";
            this.lSale.Size = new System.Drawing.Size(65, 12);
            this.lSale.TabIndex = 0;
            this.lSale.Text = "销售价格：";
            // 
            // lPurchase
            // 
            this.lPurchase.AutoSize = true;
            this.lPurchase.Location = new System.Drawing.Point(7, 123);
            this.lPurchase.Name = "lPurchase";
            this.lPurchase.Size = new System.Drawing.Size(65, 12);
            this.lPurchase.TabIndex = 0;
            this.lPurchase.Text = "采购价格：";
            // 
            // lAmount
            // 
            this.lAmount.AutoSize = true;
            this.lAmount.Location = new System.Drawing.Point(7, 89);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(41, 12);
            this.lAmount.TabIndex = 0;
            this.lAmount.Text = "数量：";
            // 
            // lModal
            // 
            this.lModal.AutoSize = true;
            this.lModal.Location = new System.Drawing.Point(7, 55);
            this.lModal.Name = "lModal";
            this.lModal.Size = new System.Drawing.Size(41, 12);
            this.lModal.TabIndex = 0;
            this.lModal.Text = "型号：";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(7, 21);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(41, 12);
            this.lName.TabIndex = 0;
            this.lName.Text = "名称：";
            // 
            // llUp
            // 
            this.llUp.AutoSize = true;
            this.llUp.Location = new System.Drawing.Point(12, 579);
            this.llUp.Name = "llUp";
            this.llUp.Size = new System.Drawing.Size(41, 12);
            this.llUp.TabIndex = 5;
            this.llUp.TabStop = true;
            this.llUp.Text = "上一页";
            this.llUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUp_LinkClicked);
            // 
            // llDown
            // 
            this.llDown.AutoSize = true;
            this.llDown.Location = new System.Drawing.Point(192, 579);
            this.llDown.Name = "llDown";
            this.llDown.Size = new System.Drawing.Size(41, 12);
            this.llDown.TabIndex = 5;
            this.llDown.TabStop = true;
            this.llDown.Text = "下一页";
            this.llDown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDown_LinkClicked);
            // 
            // lPageNumber
            // 
            this.lPageNumber.AutoSize = true;
            this.lPageNumber.Location = new System.Drawing.Point(95, 579);
            this.lPageNumber.Name = "lPageNumber";
            this.lPageNumber.Size = new System.Drawing.Size(35, 12);
            this.lPageNumber.TabIndex = 6;
            this.lPageNumber.Text = "1/100";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 598);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(773, 22);
            this.ssStatus.TabIndex = 7;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(116, 17);
            this.tslStatus.Text = "操作状态反馈。。。";
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 620);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.lPageNumber);
            this.Controls.Add(this.llDown);
            this.Controls.Add(this.llUp);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.gbSNID);
            this.Controls.Add(this.rtbStock);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.tsStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStock";
            this.Text = "库存管理";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.tsStock.ResumeLayout(false);
            this.tsStock.PerformLayout();
            this.gbSNID.ResumeLayout(false);
            this.gbSNID.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsStock;
        private System.Windows.Forms.ToolStripLabel tslStock;
        private System.Windows.Forms.ToolStripTextBox tstxtStock;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripSeparator tssStock;
        private System.Windows.Forms.ToolStripButton tsbInStock;
        private System.Windows.Forms.ToolStripButton tsbOutStock;
        private System.Windows.Forms.ListBox lbStock;
        private System.Windows.Forms.RichTextBox rtbStock;
        private System.Windows.Forms.GroupBox gbSNID;
        private System.Windows.Forms.Button btnSNSave;
        private System.Windows.Forms.TextBox txtSNID;
        private System.Windows.Forms.Label lSNOut;
        private System.Windows.Forms.Label lSNIn;
        private System.Windows.Forms.ListBox lbSNOut;
        private System.Windows.Forms.ListBox lbSNIn;
        private System.Windows.Forms.Button btnSNOut;
        private System.Windows.Forms.Button btnSNIn;
        private System.Windows.Forms.TextBox txtStockModal;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label lStockModal;
        private System.Windows.Forms.Label lStockName;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.ComboBox cbbUnit;
        private System.Windows.Forms.ComboBox cbbWare;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.NumericUpDown nNum;
        private System.Windows.Forms.Label lRemark;
        private System.Windows.Forms.Label lunit;
        private System.Windows.Forms.Label lWare;
        private System.Windows.Forms.TextBox txtModal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lSale;
        private System.Windows.Forms.Label lPurchase;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.Label lModal;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.LinkLabel llUp;
        private System.Windows.Forms.LinkLabel llDown;
        private System.Windows.Forms.Label lPageNumber;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
    }
}