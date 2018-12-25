namespace AdvtechManagementSystem
{
    partial class frmUsermanage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsermanage));
            this.tsUserinfo = new System.Windows.Forms.ToolStrip();
            this.tslUser = new System.Windows.Forms.ToolStripLabel();
            this.tstText = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.lbUser = new System.Windows.Forms.ListBox();
            this.rtbUser = new System.Windows.Forms.RichTextBox();
            this.btninitialize = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ssUser = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.cbbJob = new System.Windows.Forms.ComboBox();
            this.cbbSection = new System.Windows.Forms.ComboBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.rdbGirl = new System.Windows.Forms.RadioButton();
            this.rdbBoy = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsUserinfo.SuspendLayout();
            this.ssUser.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsUserinfo
            // 
            this.tsUserinfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tstText,
            this.tsbSelect});
            this.tsUserinfo.Location = new System.Drawing.Point(0, 0);
            this.tsUserinfo.Name = "tsUserinfo";
            this.tsUserinfo.Size = new System.Drawing.Size(659, 25);
            this.tsUserinfo.TabIndex = 0;
            this.tsUserinfo.Text = "toolStrip1";
            // 
            // tslUser
            // 
            this.tslUser.Name = "tslUser";
            this.tslUser.Size = new System.Drawing.Size(56, 22);
            this.tslUser.Text = "用户名：";
            // 
            // tstText
            // 
            this.tstText.Name = "tstText";
            this.tstText.Size = new System.Drawing.Size(150, 25);
            this.tstText.Enter += new System.EventHandler(this.tstText_Enter);
            this.tstText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstText_KeyPress);
            // 
            // tsbSelect
            // 
            this.tsbSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(23, 22);
            this.tsbSelect.Text = "查询";
            this.tsbSelect.ToolTipText = "为空查询全部";
            this.tsbSelect.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // lbUser
            // 
            this.lbUser.FormattingEnabled = true;
            this.lbUser.ItemHeight = 12;
            this.lbUser.Location = new System.Drawing.Point(12, 28);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(120, 316);
            this.lbUser.TabIndex = 1;
            this.lbUser.SelectedValueChanged += new System.EventHandler(this.lbUser_SelectedValueChanged);
            this.lbUser.DoubleClick += new System.EventHandler(this.lbUser_DoubleClick);
            // 
            // rtbUser
            // 
            this.rtbUser.Location = new System.Drawing.Point(138, 28);
            this.rtbUser.Name = "rtbUser";
            this.rtbUser.ReadOnly = true;
            this.rtbUser.Size = new System.Drawing.Size(509, 158);
            this.rtbUser.TabIndex = 2;
            this.rtbUser.Text = "";
            // 
            // btninitialize
            // 
            this.btninitialize.Location = new System.Drawing.Point(12, 357);
            this.btninitialize.Name = "btninitialize";
            this.btninitialize.Size = new System.Drawing.Size(120, 24);
            this.btninitialize.TabIndex = 4;
            this.btninitialize.Text = "初始化";
            this.btninitialize.UseVisualStyleBackColor = true;
            this.btninitialize.Click += new System.EventHandler(this.btninitialize_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 24);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 417);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(120, 24);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 24);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ssUser
            // 
            this.ssUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssUser.Location = new System.Drawing.Point(0, 491);
            this.ssUser.Name = "ssUser";
            this.ssUser.Size = new System.Drawing.Size(659, 22);
            this.ssUser.TabIndex = 4;
            this.ssUser.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(128, 17);
            this.tsslStatus.Text = "用户状态反馈。。。。";
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.rtbRemark);
            this.gbUser.Controls.Add(this.rtbAddress);
            this.gbUser.Controls.Add(this.cbbLevel);
            this.gbUser.Controls.Add(this.cbbJob);
            this.gbUser.Controls.Add(this.cbbSection);
            this.gbUser.Controls.Add(this.dtpBirth);
            this.gbUser.Controls.Add(this.rdbGirl);
            this.gbUser.Controls.Add(this.rdbBoy);
            this.gbUser.Controls.Add(this.label9);
            this.gbUser.Controls.Add(this.label8);
            this.gbUser.Controls.Add(this.label7);
            this.gbUser.Controls.Add(this.txtPhone);
            this.gbUser.Controls.Add(this.label6);
            this.gbUser.Controls.Add(this.label5);
            this.gbUser.Controls.Add(this.label4);
            this.gbUser.Controls.Add(this.label3);
            this.gbUser.Controls.Add(this.label2);
            this.gbUser.Controls.Add(this.txtUsername);
            this.gbUser.Controls.Add(this.label1);
            this.gbUser.Location = new System.Drawing.Point(139, 193);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(508, 278);
            this.gbUser.TabIndex = 3;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "用户信息";
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(279, 123);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(214, 125);
            this.rtbRemark.TabIndex = 10;
            this.rtbRemark.Text = "";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(279, 25);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(214, 92);
            this.rtbAddress.TabIndex = 9;
            this.rtbAddress.Text = "";
            // 
            // cbbLevel
            // 
            this.cbbLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "最高管理",
            "仓库管理",
            "采购管理",
            "行政管理",
            "技术管理",
            "售后管理",
            "客服管理"});
            this.cbbLevel.Location = new System.Drawing.Point(84, 223);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(121, 20);
            this.cbbLevel.TabIndex = 8;
            // 
            // cbbJob
            // 
            this.cbbJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbJob.FormattingEnabled = true;
            this.cbbJob.Items.AddRange(new object[] {
            "总经理",
            "经理",
            "员工"});
            this.cbbJob.Location = new System.Drawing.Point(84, 157);
            this.cbbJob.Name = "cbbJob";
            this.cbbJob.Size = new System.Drawing.Size(121, 20);
            this.cbbJob.TabIndex = 6;
            // 
            // cbbSection
            // 
            this.cbbSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSection.FormattingEnabled = true;
            this.cbbSection.Items.AddRange(new object[] {
            "管理部",
            "仓储部",
            "业务部",
            "采购部",
            "财务部",
            "行政部",
            "技术部",
            "售后部",
            "客服部"});
            this.cbbSection.Location = new System.Drawing.Point(84, 123);
            this.cbbSection.Name = "cbbSection";
            this.cbbSection.Size = new System.Drawing.Size(121, 20);
            this.cbbSection.TabIndex = 5;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(84, 88);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(121, 21);
            this.dtpBirth.TabIndex = 4;
            // 
            // rdbGirl
            // 
            this.rdbGirl.AutoSize = true;
            this.rdbGirl.Location = new System.Drawing.Point(144, 59);
            this.rdbGirl.Name = "rdbGirl";
            this.rdbGirl.Size = new System.Drawing.Size(35, 16);
            this.rdbGirl.TabIndex = 3;
            this.rdbGirl.Text = "女";
            this.rdbGirl.UseVisualStyleBackColor = true;
            // 
            // rdbBoy
            // 
            this.rdbBoy.AutoSize = true;
            this.rdbBoy.Checked = true;
            this.rdbBoy.Location = new System.Drawing.Point(103, 59);
            this.rdbBoy.Name = "rdbBoy";
            this.rdbBoy.Size = new System.Drawing.Size(35, 16);
            this.rdbBoy.TabIndex = 2;
            this.rdbBoy.TabStop = true;
            this.rdbBoy.Text = "男";
            this.rdbBoy.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "权限";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "联系地址";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(84, 190);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(121, 21);
            this.txtPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "联系电话";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "职务";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "所属部门";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "出生日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(84, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 21);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // frmUsermanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 513);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.ssUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btninitialize);
            this.Controls.Add(this.rtbUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tsUserinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsermanage";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.frmUsermanage_Load);
            this.tsUserinfo.ResumeLayout(false);
            this.tsUserinfo.PerformLayout();
            this.ssUser.ResumeLayout(false);
            this.ssUser.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsUserinfo;
        private System.Windows.Forms.ToolStripLabel tslUser;
        private System.Windows.Forms.ToolStripTextBox tstText;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ListBox lbUser;
        private System.Windows.Forms.RichTextBox rtbUser;
        private System.Windows.Forms.Button btninitialize;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.StatusStrip ssUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.ComboBox cbbJob;
        private System.Windows.Forms.ComboBox cbbSection;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.RadioButton rdbGirl;
        private System.Windows.Forms.RadioButton rdbBoy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
    }
}