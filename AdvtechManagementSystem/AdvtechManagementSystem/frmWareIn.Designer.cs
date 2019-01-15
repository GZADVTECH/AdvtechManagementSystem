namespace AdvtechManagementSystem
{
    partial class frmWareIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWareIn));
            this.tsIn = new System.Windows.Forms.ToolStrip();
            this.tslIn = new System.Windows.Forms.ToolStripLabel();
            this.tstxtIn = new System.Windows.Forms.ToolStripTextBox();
            this.tsbIn = new System.Windows.Forms.ToolStripButton();
            this.ssIn = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lCargoid = new System.Windows.Forms.Label();
            this.txtCargoid = new System.Windows.Forms.TextBox();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.cbbUnit = new System.Windows.Forms.ComboBox();
            this.cbbWare = new System.Windows.Forms.ComboBox();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.nNum = new System.Windows.Forms.NumericUpDown();
            this.lRemark = new System.Windows.Forms.Label();
            this.lunit = new System.Windows.Forms.Label();
            this.lWare = new System.Windows.Forms.Label();
            this.lSale = new System.Windows.Forms.Label();
            this.lPurchase = new System.Windows.Forms.Label();
            this.lAmount = new System.Windows.Forms.Label();
            this.lModal = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.cbbModal = new System.Windows.Forms.ComboBox();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.gbSnid = new System.Windows.Forms.GroupBox();
            this.rtbRecord = new System.Windows.Forms.RichTextBox();
            this.txtSnid = new System.Windows.Forms.TextBox();
            this.lRecord = new System.Windows.Forms.Label();
            this.lSnid = new System.Windows.Forms.Label();
            this.lContent = new System.Windows.Forms.Label();
            this.tsIn.SuspendLayout();
            this.ssIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).BeginInit();
            this.gbStock.SuspendLayout();
            this.gbSnid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsIn
            // 
            this.tsIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslIn,
            this.tstxtIn,
            this.tsbIn});
            this.tsIn.Location = new System.Drawing.Point(0, 0);
            this.tsIn.Name = "tsIn";
            this.tsIn.Size = new System.Drawing.Size(822, 25);
            this.tsIn.TabIndex = 0;
            this.tsIn.Text = "toolStrip1";
            // 
            // tslIn
            // 
            this.tslIn.Name = "tslIn";
            this.tslIn.Size = new System.Drawing.Size(68, 22);
            this.tslIn.Text = "记录查询：";
            // 
            // tstxtIn
            // 
            this.tstxtIn.Name = "tstxtIn";
            this.tstxtIn.Size = new System.Drawing.Size(150, 25);
            // 
            // tsbIn
            // 
            this.tsbIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbIn.Image")));
            this.tsbIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIn.Name = "tsbIn";
            this.tsbIn.Size = new System.Drawing.Size(23, 22);
            this.tsbIn.Text = "toolStripButton1";
            this.tsbIn.Click += new System.EventHandler(this.tsbIn_Click);
            // 
            // ssIn
            // 
            this.ssIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.ssIn.Location = new System.Drawing.Point(0, 513);
            this.ssIn.Name = "ssIn";
            this.ssIn.Size = new System.Drawing.Size(822, 22);
            this.ssIn.TabIndex = 1;
            this.ssIn.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(92, 17);
            this.tssStatus.Text = "操作反馈。。。";
            // 
            // lCargoid
            // 
            this.lCargoid.AutoSize = true;
            this.lCargoid.Location = new System.Drawing.Point(11, 91);
            this.lCargoid.Name = "lCargoid";
            this.lCargoid.Size = new System.Drawing.Size(65, 12);
            this.lCargoid.TabIndex = 3;
            this.lCargoid.Text = "产品编号：";
            // 
            // txtCargoid
            // 
            this.txtCargoid.Location = new System.Drawing.Point(84, 88);
            this.txtCargoid.Name = "txtCargoid";
            this.txtCargoid.Size = new System.Drawing.Size(180, 21);
            this.txtCargoid.TabIndex = 3;
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(84, 253);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(180, 176);
            this.rtbRemark.TabIndex = 9;
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
            this.cbbUnit.Location = new System.Drawing.Point(209, 220);
            this.cbbUnit.Name = "cbbUnit";
            this.cbbUnit.Size = new System.Drawing.Size(55, 20);
            this.cbbUnit.TabIndex = 8;
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
            this.cbbWare.Location = new System.Drawing.Point(84, 220);
            this.cbbWare.Name = "cbbWare";
            this.cbbWare.Size = new System.Drawing.Size(78, 20);
            this.cbbWare.TabIndex = 7;
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(84, 187);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(180, 21);
            this.txtSale.TabIndex = 6;
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(83, 154);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(180, 21);
            this.txtPurchase.TabIndex = 5;
            // 
            // nNum
            // 
            this.nNum.Location = new System.Drawing.Point(84, 122);
            this.nNum.Name = "nNum";
            this.nNum.Size = new System.Drawing.Size(180, 21);
            this.nNum.TabIndex = 4;
            // 
            // lRemark
            // 
            this.lRemark.AutoSize = true;
            this.lRemark.Location = new System.Drawing.Point(12, 256);
            this.lRemark.Name = "lRemark";
            this.lRemark.Size = new System.Drawing.Size(41, 12);
            this.lRemark.TabIndex = 15;
            this.lRemark.Text = "备注：";
            // 
            // lunit
            // 
            this.lunit.AutoSize = true;
            this.lunit.Location = new System.Drawing.Point(168, 223);
            this.lunit.Name = "lunit";
            this.lunit.Size = new System.Drawing.Size(41, 12);
            this.lunit.TabIndex = 16;
            this.lunit.Text = "单位：";
            // 
            // lWare
            // 
            this.lWare.AutoSize = true;
            this.lWare.Location = new System.Drawing.Point(12, 223);
            this.lWare.Name = "lWare";
            this.lWare.Size = new System.Drawing.Size(65, 12);
            this.lWare.TabIndex = 17;
            this.lWare.Text = "存放位置：";
            // 
            // lSale
            // 
            this.lSale.AutoSize = true;
            this.lSale.Location = new System.Drawing.Point(12, 190);
            this.lSale.Name = "lSale";
            this.lSale.Size = new System.Drawing.Size(65, 12);
            this.lSale.TabIndex = 9;
            this.lSale.Text = "销售价格：";
            // 
            // lPurchase
            // 
            this.lPurchase.AutoSize = true;
            this.lPurchase.Location = new System.Drawing.Point(12, 157);
            this.lPurchase.Name = "lPurchase";
            this.lPurchase.Size = new System.Drawing.Size(65, 12);
            this.lPurchase.TabIndex = 10;
            this.lPurchase.Text = "采购价格：";
            // 
            // lAmount
            // 
            this.lAmount.AutoSize = true;
            this.lAmount.Location = new System.Drawing.Point(12, 124);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(41, 12);
            this.lAmount.TabIndex = 11;
            this.lAmount.Text = "数量：";
            // 
            // lModal
            // 
            this.lModal.AutoSize = true;
            this.lModal.Location = new System.Drawing.Point(12, 58);
            this.lModal.Name = "lModal";
            this.lModal.Size = new System.Drawing.Size(41, 12);
            this.lModal.TabIndex = 12;
            this.lModal.Text = "型号：";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 25);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(41, 12);
            this.lName.TabIndex = 13;
            this.lName.Text = "名称：";
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.cbbModal);
            this.gbStock.Controls.Add(this.cbbName);
            this.gbStock.Controls.Add(this.btnSave);
            this.gbStock.Controls.Add(this.lCargoid);
            this.gbStock.Controls.Add(this.rtbRemark);
            this.gbStock.Controls.Add(this.cbbUnit);
            this.gbStock.Controls.Add(this.lName);
            this.gbStock.Controls.Add(this.txtCargoid);
            this.gbStock.Controls.Add(this.cbbWare);
            this.gbStock.Controls.Add(this.lModal);
            this.gbStock.Controls.Add(this.txtSale);
            this.gbStock.Controls.Add(this.lAmount);
            this.gbStock.Controls.Add(this.txtPurchase);
            this.gbStock.Controls.Add(this.lPurchase);
            this.gbStock.Controls.Add(this.nNum);
            this.gbStock.Controls.Add(this.lSale);
            this.gbStock.Controls.Add(this.lRemark);
            this.gbStock.Controls.Add(this.lunit);
            this.gbStock.Controls.Add(this.lWare);
            this.gbStock.Location = new System.Drawing.Point(0, 29);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(287, 480);
            this.gbStock.TabIndex = 25;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "货物信息";
            // 
            // cbbModal
            // 
            this.cbbModal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbModal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbModal.FormattingEnabled = true;
            this.cbbModal.Location = new System.Drawing.Point(84, 55);
            this.cbbModal.Name = "cbbModal";
            this.cbbModal.Size = new System.Drawing.Size(180, 20);
            this.cbbModal.TabIndex = 2;
            this.cbbModal.SelectedValueChanged += new System.EventHandler(this.cbbModal_SelectedValueChanged);
            this.cbbModal.Leave += new System.EventHandler(this.cbbModal_Leave);
            // 
            // cbbName
            // 
            this.cbbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(84, 22);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(180, 20);
            this.cbbName.TabIndex = 1;
            this.cbbName.SelectedValueChanged += new System.EventHandler(this.cbbName_SelectedValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(293, 198);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(517, 311);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // gbSnid
            // 
            this.gbSnid.Controls.Add(this.rtbRecord);
            this.gbSnid.Controls.Add(this.txtSnid);
            this.gbSnid.Controls.Add(this.lRecord);
            this.gbSnid.Controls.Add(this.lSnid);
            this.gbSnid.Location = new System.Drawing.Point(294, 29);
            this.gbSnid.Name = "gbSnid";
            this.gbSnid.Size = new System.Drawing.Size(516, 139);
            this.gbSnid.TabIndex = 27;
            this.gbSnid.TabStop = false;
            this.gbSnid.Text = "S/N码录入";
            // 
            // rtbRecord
            // 
            this.rtbRecord.Location = new System.Drawing.Point(67, 52);
            this.rtbRecord.Name = "rtbRecord";
            this.rtbRecord.ReadOnly = true;
            this.rtbRecord.Size = new System.Drawing.Size(434, 84);
            this.rtbRecord.TabIndex = 2;
            this.rtbRecord.Text = "";
            this.rtbRecord.TextChanged += new System.EventHandler(this.rtbRecord_TextChanged);
            // 
            // txtSnid
            // 
            this.txtSnid.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtSnid.Location = new System.Drawing.Point(67, 25);
            this.txtSnid.Name = "txtSnid";
            this.txtSnid.Size = new System.Drawing.Size(434, 21);
            this.txtSnid.TabIndex = 1;
            this.txtSnid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSnid_KeyPress);
            // 
            // lRecord
            // 
            this.lRecord.AutoSize = true;
            this.lRecord.Location = new System.Drawing.Point(6, 58);
            this.lRecord.Name = "lRecord";
            this.lRecord.Size = new System.Drawing.Size(53, 12);
            this.lRecord.TabIndex = 5;
            this.lRecord.Text = "操作记录";
            // 
            // lSnid
            // 
            this.lSnid.AutoSize = true;
            this.lSnid.Location = new System.Drawing.Point(9, 28);
            this.lSnid.Name = "lSnid";
            this.lSnid.Size = new System.Drawing.Size(47, 12);
            this.lSnid.TabIndex = 5;
            this.lSnid.Text = "S/N码：";
            // 
            // lContent
            // 
            this.lContent.AutoSize = true;
            this.lContent.Location = new System.Drawing.Point(293, 183);
            this.lContent.Name = "lContent";
            this.lContent.Size = new System.Drawing.Size(65, 12);
            this.lContent.TabIndex = 28;
            this.lContent.Text = "详细内容：";
            // 
            // frmWareIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 535);
            this.Controls.Add(this.lContent);
            this.Controls.Add(this.gbSnid);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.ssIn);
            this.Controls.Add(this.tsIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWareIn";
            this.Text = "入库";
            this.Load += new System.EventHandler(this.frmWareIn_Load);
            this.tsIn.ResumeLayout(false);
            this.tsIn.PerformLayout();
            this.ssIn.ResumeLayout(false);
            this.ssIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).EndInit();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            this.gbSnid.ResumeLayout(false);
            this.gbSnid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsIn;
        private System.Windows.Forms.ToolStripLabel tslIn;
        private System.Windows.Forms.ToolStripTextBox tstxtIn;
        private System.Windows.Forms.ToolStripButton tsbIn;
        private System.Windows.Forms.StatusStrip ssIn;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Label lCargoid;
        private System.Windows.Forms.TextBox txtCargoid;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.ComboBox cbbUnit;
        private System.Windows.Forms.ComboBox cbbWare;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.NumericUpDown nNum;
        private System.Windows.Forms.Label lRemark;
        private System.Windows.Forms.Label lunit;
        private System.Windows.Forms.Label lWare;
        private System.Windows.Forms.Label lSale;
        private System.Windows.Forms.Label lPurchase;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.Label lModal;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.GroupBox gbSnid;
        private System.Windows.Forms.Label lContent;
        private System.Windows.Forms.RichTextBox rtbRecord;
        private System.Windows.Forms.TextBox txtSnid;
        private System.Windows.Forms.Label lSnid;
        private System.Windows.Forms.Label lRecord;
        private System.Windows.Forms.ComboBox cbbModal;
    }
}