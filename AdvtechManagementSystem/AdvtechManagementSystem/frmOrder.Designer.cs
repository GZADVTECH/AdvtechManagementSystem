namespace AdvtechManagementSystem
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.cbInvoice = new System.Windows.Forms.CheckBox();
            this.cbMatch = new System.Windows.Forms.CheckBox();
            this.cbbModal = new System.Windows.Forms.ComboBox();
            this.cbbCargo = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.nNum = new System.Windows.Forms.NumericUpDown();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCargoid = new System.Windows.Forms.TextBox();
            this.txtOfficial = new System.Windows.Forms.TextBox();
            this.txtInternal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lRemark = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lAmount = new System.Windows.Forms.Label();
            this.lInvoice = new System.Windows.Forms.Label();
            this.lMatch = new System.Windows.Forms.Label();
            this.lModal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lCargo = new System.Windows.Forms.Label();
            this.lOfficialNumber = new System.Windows.Forms.Label();
            this.lInternalNumber = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.ssStatus.SuspendLayout();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 548);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(836, 22);
            this.ssStatus.TabIndex = 0;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(92, 17);
            this.tslStatus.Text = "操作反馈。。。";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.cbInvoice);
            this.gbOrder.Controls.Add(this.cbMatch);
            this.gbOrder.Controls.Add(this.cbbModal);
            this.gbOrder.Controls.Add(this.cbbCargo);
            this.gbOrder.Controls.Add(this.btnSave);
            this.gbOrder.Controls.Add(this.rtbRemark);
            this.gbOrder.Controls.Add(this.nNum);
            this.gbOrder.Controls.Add(this.txtPurchase);
            this.gbOrder.Controls.Add(this.txtTotal);
            this.gbOrder.Controls.Add(this.txtCargoid);
            this.gbOrder.Controls.Add(this.txtOfficial);
            this.gbOrder.Controls.Add(this.txtInternal);
            this.gbOrder.Controls.Add(this.label1);
            this.gbOrder.Controls.Add(this.lRemark);
            this.gbOrder.Controls.Add(this.lTotal);
            this.gbOrder.Controls.Add(this.lAmount);
            this.gbOrder.Controls.Add(this.lInvoice);
            this.gbOrder.Controls.Add(this.lMatch);
            this.gbOrder.Controls.Add(this.lModal);
            this.gbOrder.Controls.Add(this.label2);
            this.gbOrder.Controls.Add(this.lCargo);
            this.gbOrder.Controls.Add(this.lOfficialNumber);
            this.gbOrder.Controls.Add(this.lInternalNumber);
            this.gbOrder.Location = new System.Drawing.Point(12, 12);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(296, 531);
            this.gbOrder.TabIndex = 2;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "采购信息";
            // 
            // cbInvoice
            // 
            this.cbInvoice.AutoSize = true;
            this.cbInvoice.Location = new System.Drawing.Point(128, 207);
            this.cbInvoice.Name = "cbInvoice";
            this.cbInvoice.Size = new System.Drawing.Size(96, 16);
            this.cbInvoice.TabIndex = 6;
            this.cbInvoice.Text = "附带相应发票";
            this.cbInvoice.UseVisualStyleBackColor = true;
            // 
            // cbMatch
            // 
            this.cbMatch.AutoSize = true;
            this.cbMatch.Location = new System.Drawing.Point(128, 177);
            this.cbMatch.Name = "cbMatch";
            this.cbMatch.Size = new System.Drawing.Size(96, 16);
            this.cbMatch.TabIndex = 5;
            this.cbMatch.Text = "包含配套产品";
            this.cbMatch.UseVisualStyleBackColor = true;
            // 
            // cbbModal
            // 
            this.cbbModal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbModal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbModal.FormattingEnabled = true;
            this.cbbModal.Location = new System.Drawing.Point(94, 115);
            this.cbbModal.Name = "cbbModal";
            this.cbbModal.Size = new System.Drawing.Size(177, 20);
            this.cbbModal.TabIndex = 3;
            this.cbbModal.SelectedValueChanged += new System.EventHandler(this.cbbModal_SelectedValueChanged);
            this.cbbModal.Leave += new System.EventHandler(this.cbbModal_Leave);
            // 
            // cbbCargo
            // 
            this.cbbCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCargo.FormattingEnabled = true;
            this.cbbCargo.Location = new System.Drawing.Point(94, 85);
            this.cbbCargo.Name = "cbbCargo";
            this.cbbCargo.Size = new System.Drawing.Size(177, 20);
            this.cbbCargo.TabIndex = 2;
            this.cbbCargo.SelectedValueChanged += new System.EventHandler(this.cbbCargo_SelectedValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(94, 325);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(177, 147);
            this.rtbRemark.TabIndex = 10;
            this.rtbRemark.Text = "如需标注是否含税，请在此处填写（例:采购价格不含税，销售价格含税）";
            this.rtbRemark.Enter += new System.EventHandler(this.rtbRemark_Enter);
            this.rtbRemark.Leave += new System.EventHandler(this.rtbRemark_Leave);
            // 
            // nNum
            // 
            this.nNum.Location = new System.Drawing.Point(94, 236);
            this.nNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nNum.Name = "nNum";
            this.nNum.Size = new System.Drawing.Size(177, 21);
            this.nNum.TabIndex = 7;
            this.nNum.ValueChanged += new System.EventHandler(this.nNum_ValueChanged);
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(94, 265);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(177, 21);
            this.txtPurchase.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(94, 295);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(177, 21);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "0";
            // 
            // txtCargoid
            // 
            this.txtCargoid.Location = new System.Drawing.Point(94, 145);
            this.txtCargoid.Name = "txtCargoid";
            this.txtCargoid.Size = new System.Drawing.Size(177, 21);
            this.txtCargoid.TabIndex = 4;
            // 
            // txtOfficial
            // 
            this.txtOfficial.Location = new System.Drawing.Point(94, 55);
            this.txtOfficial.Name = "txtOfficial";
            this.txtOfficial.Size = new System.Drawing.Size(177, 21);
            this.txtOfficial.TabIndex = 1;
            // 
            // txtInternal
            // 
            this.txtInternal.Location = new System.Drawing.Point(94, 25);
            this.txtInternal.Name = "txtInternal";
            this.txtInternal.Size = new System.Drawing.Size(177, 21);
            this.txtInternal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "采购价格";
            // 
            // lRemark
            // 
            this.lRemark.AutoSize = true;
            this.lRemark.Location = new System.Drawing.Point(25, 328);
            this.lRemark.Name = "lRemark";
            this.lRemark.Size = new System.Drawing.Size(29, 12);
            this.lRemark.TabIndex = 1;
            this.lRemark.Text = "备注";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(16, 298);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(53, 12);
            this.lTotal.TabIndex = 1;
            this.lTotal.Text = "采购总值";
            // 
            // lAmount
            // 
            this.lAmount.AutoSize = true;
            this.lAmount.Location = new System.Drawing.Point(16, 238);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(53, 12);
            this.lAmount.TabIndex = 0;
            this.lAmount.Text = "采购数量";
            // 
            // lInvoice
            // 
            this.lInvoice.AutoSize = true;
            this.lInvoice.Location = new System.Drawing.Point(16, 208);
            this.lInvoice.Name = "lInvoice";
            this.lInvoice.Size = new System.Drawing.Size(53, 12);
            this.lInvoice.TabIndex = 0;
            this.lInvoice.Text = "附带发票";
            // 
            // lMatch
            // 
            this.lMatch.AutoSize = true;
            this.lMatch.Location = new System.Drawing.Point(16, 178);
            this.lMatch.Name = "lMatch";
            this.lMatch.Size = new System.Drawing.Size(53, 12);
            this.lMatch.TabIndex = 0;
            this.lMatch.Text = "是否配套";
            // 
            // lModal
            // 
            this.lModal.AutoSize = true;
            this.lModal.Location = new System.Drawing.Point(16, 118);
            this.lModal.Name = "lModal";
            this.lModal.Size = new System.Drawing.Size(53, 12);
            this.lModal.TabIndex = 0;
            this.lModal.Text = "货物型号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "货物编号";
            // 
            // lCargo
            // 
            this.lCargo.AutoSize = true;
            this.lCargo.Location = new System.Drawing.Point(16, 88);
            this.lCargo.Name = "lCargo";
            this.lCargo.Size = new System.Drawing.Size(53, 12);
            this.lCargo.TabIndex = 0;
            this.lCargo.Text = "货物名称";
            // 
            // lOfficialNumber
            // 
            this.lOfficialNumber.AutoSize = true;
            this.lOfficialNumber.Location = new System.Drawing.Point(10, 58);
            this.lOfficialNumber.Name = "lOfficialNumber";
            this.lOfficialNumber.Size = new System.Drawing.Size(65, 12);
            this.lOfficialNumber.TabIndex = 0;
            this.lOfficialNumber.Text = "合同订单号";
            // 
            // lInternalNumber
            // 
            this.lInternalNumber.AutoSize = true;
            this.lInternalNumber.Location = new System.Drawing.Point(10, 28);
            this.lInternalNumber.Name = "lInternalNumber";
            this.lInternalNumber.Size = new System.Drawing.Size(65, 12);
            this.lInternalNumber.TabIndex = 0;
            this.lInternalNumber.Text = "内部订单号";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(315, 12);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(509, 531);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 570);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.ssStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrder";
            this.Text = "采购订单";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.ComboBox cbbModal;
        private System.Windows.Forms.ComboBox cbbCargo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.NumericUpDown nNum;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtOfficial;
        private System.Windows.Forms.TextBox txtInternal;
        private System.Windows.Forms.Label lRemark;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.Label lInvoice;
        private System.Windows.Forms.Label lMatch;
        private System.Windows.Forms.Label lModal;
        private System.Windows.Forms.Label lCargo;
        private System.Windows.Forms.Label lInternalNumber;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.CheckBox cbInvoice;
        private System.Windows.Forms.CheckBox cbMatch;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCargoid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lOfficialNumber;
    }
}