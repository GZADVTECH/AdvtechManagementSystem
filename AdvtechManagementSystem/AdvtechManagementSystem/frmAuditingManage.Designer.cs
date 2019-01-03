namespace AdvtechManagementSystem
{
    partial class frmAuditingManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditingManage));
            this.lbAuditing = new System.Windows.Forms.ListBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lAuditing = new System.Windows.Forms.Label();
            this.lContent = new System.Windows.Forms.Label();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.lRemark = new System.Windows.Forms.Label();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAuditing
            // 
            this.lbAuditing.FormattingEnabled = true;
            this.lbAuditing.ItemHeight = 12;
            this.lbAuditing.Location = new System.Drawing.Point(13, 43);
            this.lbAuditing.Name = "lbAuditing";
            this.lbAuditing.Size = new System.Drawing.Size(246, 532);
            this.lbAuditing.TabIndex = 0;
            this.lbAuditing.SelectedValueChanged += new System.EventHandler(this.lbAuditing_SelectedValueChanged);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(265, 43);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(495, 386);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(685, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "驳回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "通过";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 583);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(772, 22);
            this.ssStatus.TabIndex = 3;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(92, 17);
            this.tslStatus.Text = "操作反馈。。。";
            // 
            // lAuditing
            // 
            this.lAuditing.AutoSize = true;
            this.lAuditing.Location = new System.Drawing.Point(13, 25);
            this.lAuditing.Name = "lAuditing";
            this.lAuditing.Size = new System.Drawing.Size(53, 12);
            this.lAuditing.TabIndex = 4;
            this.lAuditing.Text = "审核大纲";
            // 
            // lContent
            // 
            this.lContent.AutoSize = true;
            this.lContent.Location = new System.Drawing.Point(263, 25);
            this.lContent.Name = "lContent";
            this.lContent.Size = new System.Drawing.Size(53, 12);
            this.lContent.TabIndex = 4;
            this.lContent.Text = "详细内容";
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(267, 450);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(495, 125);
            this.rtbRemark.TabIndex = 1;
            this.rtbRemark.Text = "";
            // 
            // lRemark
            // 
            this.lRemark.AutoSize = true;
            this.lRemark.Location = new System.Drawing.Point(265, 432);
            this.lRemark.Name = "lRemark";
            this.lRemark.Size = new System.Drawing.Size(29, 12);
            this.lRemark.TabIndex = 4;
            this.lRemark.Text = "备注";
            // 
            // frmAuditingManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 605);
            this.Controls.Add(this.lRemark);
            this.Controls.Add(this.lContent);
            this.Controls.Add(this.lAuditing);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbRemark);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.lbAuditing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAuditingManage";
            this.Text = "请求审核";
            this.Load += new System.EventHandler(this.frmAuditingManage_Load);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAuditing;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.Label lAuditing;
        private System.Windows.Forms.Label lContent;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.Label lRemark;
    }
}