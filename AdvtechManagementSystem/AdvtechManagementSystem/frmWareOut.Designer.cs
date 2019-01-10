namespace AdvtechManagementSystem
{
    partial class frmWareOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWareOut));
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsOut = new System.Windows.Forms.ToolStrip();
            this.tslOut = new System.Windows.Forms.ToolStripLabel();
            this.tstxtOut = new System.Windows.Forms.ToolStripTextBox();
            this.tsbOut = new System.Windows.Forms.ToolStripButton();
            this.lContent = new System.Windows.Forms.Label();
            this.gbSnid = new System.Windows.Forms.GroupBox();
            this.rtbRecord = new System.Windows.Forms.RichTextBox();
            this.txtSnid = new System.Windows.Forms.TextBox();
            this.lRecord = new System.Windows.Forms.Label();
            this.lSnid = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.cbbModal = new System.Windows.Forms.ComboBox();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lCargoid = new System.Windows.Forms.Label();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.cbbUnit = new System.Windows.Forms.ComboBox();
            this.lName = new System.Windows.Forms.Label();
            this.txtCargoid = new System.Windows.Forms.TextBox();
            this.cbbWare = new System.Windows.Forms.ComboBox();
            this.lModal = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.lAmount = new System.Windows.Forms.Label();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.lPurchase = new System.Windows.Forms.Label();
            this.nNum = new System.Windows.Forms.NumericUpDown();
            this.lSale = new System.Windows.Forms.Label();
            this.lRemark = new System.Windows.Forms.Label();
            this.lunit = new System.Windows.Forms.Label();
            this.lWare = new System.Windows.Forms.Label();
            this.ssStatus.SuspendLayout();
            this.tsOut.SuspendLayout();
            this.gbSnid.SuspendLayout();
            this.gbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 513);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(818, 22);
            this.ssStatus.TabIndex = 0;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(92, 17);
            this.tslStatus.Text = "操作反馈。。。";
            // 
            // tsOut
            // 
            this.tsOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslOut,
            this.tstxtOut,
            this.tsbOut});
            this.tsOut.Location = new System.Drawing.Point(0, 0);
            this.tsOut.Name = "tsOut";
            this.tsOut.Size = new System.Drawing.Size(818, 25);
            this.tsOut.TabIndex = 1;
            this.tsOut.Text = "toolStrip1";
            // 
            // tslOut
            // 
            this.tslOut.Name = "tslOut";
            this.tslOut.Size = new System.Drawing.Size(68, 22);
            this.tslOut.Text = "记录查询：";
            // 
            // tstxtOut
            // 
            this.tstxtOut.Name = "tstxtOut";
            this.tstxtOut.Size = new System.Drawing.Size(150, 25);
            // 
            // tsbOut
            // 
            this.tsbOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbOut.Image")));
            this.tsbOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOut.Name = "tsbOut";
            this.tsbOut.Size = new System.Drawing.Size(23, 22);
            this.tsbOut.Text = "toolStripButton1";
            this.tsbOut.Click += new System.EventHandler(this.tsbOut_Click);
            // 
            // lContent
            // 
            this.lContent.AutoSize = true;
            this.lContent.Location = new System.Drawing.Point(292, 182);
            this.lContent.Name = "lContent";
            this.lContent.Size = new System.Drawing.Size(65, 12);
            this.lContent.TabIndex = 35;
            this.lContent.Text = "详细内容：";
            // 
            // gbSnid
            // 
            this.gbSnid.Controls.Add(this.rtbRecord);
            this.gbSnid.Controls.Add(this.txtSnid);
            this.gbSnid.Controls.Add(this.lRecord);
            this.gbSnid.Controls.Add(this.lSnid);
            this.gbSnid.Location = new System.Drawing.Point(293, 28);
            this.gbSnid.Name = "gbSnid";
            this.gbSnid.Size = new System.Drawing.Size(516, 139);
            this.gbSnid.TabIndex = 34;
            this.gbSnid.TabStop = false;
            this.gbSnid.Text = "S/N码录出";
            // 
            // rtbRecord
            // 
            this.rtbRecord.Location = new System.Drawing.Point(67, 49);
            this.rtbRecord.Name = "rtbRecord";
            this.rtbRecord.Size = new System.Drawing.Size(434, 84);
            this.rtbRecord.TabIndex = 11;
            this.rtbRecord.Text = "";
            this.rtbRecord.TextChanged += new System.EventHandler(this.rtbRecord_TextChanged);
            // 
            // txtSnid
            // 
            this.txtSnid.Location = new System.Drawing.Point(67, 22);
            this.txtSnid.Name = "txtSnid";
            this.txtSnid.Size = new System.Drawing.Size(434, 21);
            this.txtSnid.TabIndex = 10;
            this.txtSnid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSnid_KeyPress);
            // 
            // lRecord
            // 
            this.lRecord.AutoSize = true;
            this.lRecord.Location = new System.Drawing.Point(6, 55);
            this.lRecord.Name = "lRecord";
            this.lRecord.Size = new System.Drawing.Size(53, 12);
            this.lRecord.TabIndex = 8;
            this.lRecord.Text = "操作记录";
            // 
            // lSnid
            // 
            this.lSnid.AutoSize = true;
            this.lSnid.Location = new System.Drawing.Point(9, 25);
            this.lSnid.Name = "lSnid";
            this.lSnid.Size = new System.Drawing.Size(47, 12);
            this.lSnid.TabIndex = 9;
            this.lSnid.Text = "S/N码：";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(292, 197);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(517, 311);
            this.rtbContent.TabIndex = 33;
            this.rtbContent.Text = "";
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
            this.gbStock.Location = new System.Drawing.Point(0, 28);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(287, 480);
            this.gbStock.TabIndex = 32;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "货物信息";
            // 
            // cbbModal
            // 
            this.cbbModal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbModal.FormattingEnabled = true;
            this.cbbModal.Location = new System.Drawing.Point(83, 55);
            this.cbbModal.Name = "cbbModal";
            this.cbbModal.Size = new System.Drawing.Size(181, 20);
            this.cbbModal.TabIndex = 26;
            this.cbbModal.SelectedValueChanged += new System.EventHandler(this.cbbModal_SelectedValueChanged);
            // 
            // cbbName
            // 
            this.cbbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(84, 22);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(180, 20);
            this.cbbName.TabIndex = 26;
            this.cbbName.SelectedValueChanged += new System.EventHandler(this.cbbName_SelectedValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(84, 253);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(180, 176);
            this.rtbRemark.TabIndex = 24;
            this.rtbRemark.Text = "如需标注是否含税，请在此处填写（例:采购价格不含税，销售价格含税）";
            this.rtbRemark.Enter += new System.EventHandler(this.rtbRemark_Enter);
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
            this.cbbUnit.TabIndex = 23;
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
            // txtCargoid
            // 
            this.txtCargoid.Location = new System.Drawing.Point(84, 88);
            this.txtCargoid.Name = "txtCargoid";
            this.txtCargoid.ReadOnly = true;
            this.txtCargoid.Size = new System.Drawing.Size(180, 21);
            this.txtCargoid.TabIndex = 4;
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
            this.cbbWare.TabIndex = 22;
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
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(84, 187);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(180, 21);
            this.txtSale.TabIndex = 21;
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
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(83, 154);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.ReadOnly = true;
            this.txtPurchase.Size = new System.Drawing.Size(180, 21);
            this.txtPurchase.TabIndex = 20;
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
            // nNum
            // 
            this.nNum.Location = new System.Drawing.Point(84, 122);
            this.nNum.Name = "nNum";
            this.nNum.Size = new System.Drawing.Size(180, 21);
            this.nNum.TabIndex = 19;
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
            // frmWareOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 535);
            this.Controls.Add(this.lContent);
            this.Controls.Add(this.gbSnid);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.tsOut);
            this.Controls.Add(this.ssStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWareOut";
            this.Text = "出库";
            this.Load += new System.EventHandler(this.frmWareOut_Load);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tsOut.ResumeLayout(false);
            this.tsOut.PerformLayout();
            this.gbSnid.ResumeLayout(false);
            this.gbSnid.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStrip tsOut;
        private System.Windows.Forms.ToolStripLabel tslOut;
        private System.Windows.Forms.ToolStripTextBox tstxtOut;
        private System.Windows.Forms.ToolStripButton tsbOut;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.Label lContent;
        private System.Windows.Forms.GroupBox gbSnid;
        private System.Windows.Forms.RichTextBox rtbRecord;
        private System.Windows.Forms.TextBox txtSnid;
        private System.Windows.Forms.Label lRecord;
        private System.Windows.Forms.Label lSnid;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lCargoid;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.ComboBox cbbUnit;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtCargoid;
        private System.Windows.Forms.ComboBox cbbWare;
        private System.Windows.Forms.Label lModal;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Label lPurchase;
        private System.Windows.Forms.NumericUpDown nNum;
        private System.Windows.Forms.Label lSale;
        private System.Windows.Forms.Label lRemark;
        private System.Windows.Forms.Label lunit;
        private System.Windows.Forms.Label lWare;
        private System.Windows.Forms.ComboBox cbbModal;
    }
}