namespace AdvtechManagementSystem
{
    partial class frmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchase));
            this.tsPurchase = new System.Windows.Forms.ToolStrip();
            this.tsbPurchase = new System.Windows.Forms.ToolStripButton();
            this.tsbSituation = new System.Windows.Forms.ToolStripButton();
            this.tsbSupplier = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsbAuditing = new System.Windows.Forms.ToolStripButton();
            this.tsPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsPurchase
            // 
            this.tsPurchase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPurchase,
            this.tsbSituation,
            this.tsbSupplier,
            this.toolStripButton4,
            this.tsbAuditing});
            this.tsPurchase.Location = new System.Drawing.Point(0, 0);
            this.tsPurchase.Name = "tsPurchase";
            this.tsPurchase.Size = new System.Drawing.Size(1164, 25);
            this.tsPurchase.TabIndex = 1;
            this.tsPurchase.Text = "toolStrip1";
            // 
            // tsbPurchase
            // 
            this.tsbPurchase.Image = ((System.Drawing.Image)(resources.GetObject("tsbPurchase.Image")));
            this.tsbPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPurchase.Name = "tsbPurchase";
            this.tsbPurchase.Size = new System.Drawing.Size(76, 22);
            this.tsbPurchase.Text = "采购订单";
            this.tsbPurchase.Click += new System.EventHandler(this.tsbPurchase_Click);
            // 
            // tsbSituation
            // 
            this.tsbSituation.Image = ((System.Drawing.Image)(resources.GetObject("tsbSituation.Image")));
            this.tsbSituation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSituation.Name = "tsbSituation";
            this.tsbSituation.Size = new System.Drawing.Size(76, 22);
            this.tsbSituation.Text = "库存情况";
            this.tsbSituation.Click += new System.EventHandler(this.tsbSituation_Click);
            // 
            // tsbSupplier
            // 
            this.tsbSupplier.Image = ((System.Drawing.Image)(resources.GetObject("tsbSupplier.Image")));
            this.tsbSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSupplier.Name = "tsbSupplier";
            this.tsbSupplier.Size = new System.Drawing.Size(88, 22);
            this.tsbSupplier.Text = "供应商管理";
            this.tsbSupplier.Visible = false;
            this.tsbSupplier.Click += new System.EventHandler(this.tsbSupplier_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton4.Text = "实时报价";
            this.toolStripButton4.Visible = false;
            // 
            // tsbAuditing
            // 
            this.tsbAuditing.Image = ((System.Drawing.Image)(resources.GetObject("tsbAuditing.Image")));
            this.tsbAuditing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAuditing.Name = "tsbAuditing";
            this.tsbAuditing.Size = new System.Drawing.Size(76, 22);
            this.tsbAuditing.Text = "审核情况";
            this.tsbAuditing.Click += new System.EventHandler(this.tsbAuditing_Click);
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1164, 727);
            this.Controls.Add(this.tsPurchase);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPurchase";
            this.Text = "采购";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPurchase_FormClosed);
            this.tsPurchase.ResumeLayout(false);
            this.tsPurchase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsPurchase;
        private System.Windows.Forms.ToolStripButton tsbPurchase;
        private System.Windows.Forms.ToolStripButton tsbSituation;
        private System.Windows.Forms.ToolStripButton tsbSupplier;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbAuditing;
    }
}