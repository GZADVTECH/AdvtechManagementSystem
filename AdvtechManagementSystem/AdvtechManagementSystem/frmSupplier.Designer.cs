namespace AdvtechManagementSystem
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            this.tsSupplier = new System.Windows.Forms.ToolStrip();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tslStock = new System.Windows.Forms.ToolStripLabel();
            this.tstxtStock = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lbSupplier = new System.Windows.Forms.ListBox();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.lCompanyname = new System.Windows.Forms.Label();
            this.lPeople = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lAddress = new System.Windows.Forms.Label();
            this.lRemark = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCompanyname = new System.Windows.Forms.TextBox();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.tsSupplier.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSupplier
            // 
            this.tsSupplier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStock,
            this.tstxtStock,
            this.tsbSelect});
            this.tsSupplier.Location = new System.Drawing.Point(0, 0);
            this.tsSupplier.Name = "tsSupplier";
            this.tsSupplier.Size = new System.Drawing.Size(660, 25);
            this.tsSupplier.TabIndex = 0;
            this.tsSupplier.Text = "toolStrip1";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 548);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(660, 22);
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
            this.tslStatus.Size = new System.Drawing.Size(56, 17);
            this.tslStatus.Text = "操作反馈";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(229, 28);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(419, 359);
            this.rtbContent.TabIndex = 2;
            this.rtbContent.Text = "";
            // 
            // lbSupplier
            // 
            this.lbSupplier.FormattingEnabled = true;
            this.lbSupplier.ItemHeight = 12;
            this.lbSupplier.Location = new System.Drawing.Point(13, 29);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(210, 520);
            this.lbSupplier.TabIndex = 3;
            this.lbSupplier.SelectedValueChanged += new System.EventHandler(this.lbSupplier_SelectedValueChanged);
            this.lbSupplier.DoubleClick += new System.EventHandler(this.lbSupplier_DoubleClick);
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.cbStatus);
            this.gbMessage.Controls.Add(this.txtRemark);
            this.gbMessage.Controls.Add(this.txtAddress);
            this.gbMessage.Controls.Add(this.txtPhone);
            this.gbMessage.Controls.Add(this.txtPeople);
            this.gbMessage.Controls.Add(this.txtCompanyname);
            this.gbMessage.Controls.Add(this.btnSave);
            this.gbMessage.Controls.Add(this.lStatus);
            this.gbMessage.Controls.Add(this.lRemark);
            this.gbMessage.Controls.Add(this.lAddress);
            this.gbMessage.Controls.Add(this.lPhone);
            this.gbMessage.Controls.Add(this.lPeople);
            this.gbMessage.Controls.Add(this.lCompanyname);
            this.gbMessage.Location = new System.Drawing.Point(229, 394);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(419, 155);
            this.gbMessage.TabIndex = 4;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "相关信息";
            // 
            // lCompanyname
            // 
            this.lCompanyname.AutoSize = true;
            this.lCompanyname.Location = new System.Drawing.Point(11, 27);
            this.lCompanyname.Name = "lCompanyname";
            this.lCompanyname.Size = new System.Drawing.Size(53, 12);
            this.lCompanyname.TabIndex = 0;
            this.lCompanyname.Text = "公司名称";
            // 
            // lPeople
            // 
            this.lPeople.AutoSize = true;
            this.lPeople.Location = new System.Drawing.Point(222, 27);
            this.lPeople.Name = "lPeople";
            this.lPeople.Size = new System.Drawing.Size(41, 12);
            this.lPeople.TabIndex = 0;
            this.lPeople.Text = "负责人";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(11, 52);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(53, 12);
            this.lPhone.TabIndex = 0;
            this.lPhone.Text = "公司电话";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(11, 77);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(53, 12);
            this.lAddress.TabIndex = 0;
            this.lAddress.Text = "公司地址";
            // 
            // lRemark
            // 
            this.lRemark.AutoSize = true;
            this.lRemark.Location = new System.Drawing.Point(23, 102);
            this.lRemark.Name = "lRemark";
            this.lRemark.Size = new System.Drawing.Size(29, 12);
            this.lRemark.TabIndex = 0;
            this.lRemark.Text = "备注";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(222, 50);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(29, 12);
            this.lStatus.TabIndex = 0;
            this.lStatus.Text = "状态";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(338, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtCompanyname
            // 
            this.txtCompanyname.Location = new System.Drawing.Point(82, 24);
            this.txtCompanyname.Name = "txtCompanyname";
            this.txtCompanyname.Size = new System.Drawing.Size(134, 21);
            this.txtCompanyname.TabIndex = 2;
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(269, 24);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(144, 21);
            this.txtPeople.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(82, 47);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(134, 21);
            this.txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(82, 74);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(331, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(82, 99);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(331, 21);
            this.txtRemark.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(270, 51);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(72, 16);
            this.cbStatus.TabIndex = 3;
            this.cbStatus.Text = "是否供应";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 570);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.lbSupplier);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tsSupplier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupplier";
            this.Text = "供应商管理";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.tsSupplier.ResumeLayout(false);
            this.tsSupplier.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSupplier;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripLabel tslStock;
        private System.Windows.Forms.ToolStripTextBox tstxtStock;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.ListBox lbSupplier;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.TextBox txtCompanyname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lRemark;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lPeople;
        private System.Windows.Forms.Label lCompanyname;
    }
}