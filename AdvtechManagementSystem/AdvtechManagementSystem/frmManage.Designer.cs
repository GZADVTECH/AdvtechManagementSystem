namespace AdvtechManagementSystem
{
    partial class frmManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManage));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmanage = new System.Windows.Forms.ToolStrip();
            this.tsbUserinfo = new System.Windows.Forms.ToolStripButton();
            this.tsbReport = new System.Windows.Forms.ToolStripButton();
            this.tsbRequest = new System.Windows.Forms.ToolStripButton();
            this.tsmanage.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 733);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1201, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmanage
            // 
            this.tsmanage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUserinfo,
            this.tsbReport,
            this.tsbRequest});
            this.tsmanage.Location = new System.Drawing.Point(0, 0);
            this.tsmanage.Name = "tsmanage";
            this.tsmanage.Size = new System.Drawing.Size(1201, 25);
            this.tsmanage.TabIndex = 2;
            this.tsmanage.Text = "toolStrip1";
            // 
            // tsbUserinfo
            // 
            this.tsbUserinfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUserinfo.Image")));
            this.tsbUserinfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUserinfo.Name = "tsbUserinfo";
            this.tsbUserinfo.Size = new System.Drawing.Size(76, 22);
            this.tsbUserinfo.Text = "用户管理";
            this.tsbUserinfo.Click += new System.EventHandler(this.tsbUserinfo_Click);
            // 
            // tsbReport
            // 
            this.tsbReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbReport.Image")));
            this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReport.Name = "tsbReport";
            this.tsbReport.Size = new System.Drawing.Size(76, 22);
            this.tsbReport.Text = "报表查看";
            this.tsbReport.Click += new System.EventHandler(this.tsbReport_Click);
            // 
            // tsbRequest
            // 
            this.tsbRequest.Image = ((System.Drawing.Image)(resources.GetObject("tsbRequest.Image")));
            this.tsbRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRequest.Name = "tsbRequest";
            this.tsbRequest.Size = new System.Drawing.Size(76, 22);
            this.tsbRequest.Text = "请求审核";
            this.tsbRequest.Click += new System.EventHandler(this.tsbRequest_Click);
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1201, 755);
            this.Controls.Add(this.tsmanage);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManage";
            this.Text = "管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManage_FormClosed);
            this.tsmanage.ResumeLayout(false);
            this.tsmanage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip tsmanage;
        private System.Windows.Forms.ToolStripButton tsbUserinfo;
        private System.Windows.Forms.ToolStripButton tsbReport;
        private System.Windows.Forms.ToolStripButton tsbRequest;
    }
}