namespace AdvtechManagementSystem
{
    partial class frmWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsWarehouse = new System.Windows.Forms.ToolStrip();
            this.tsbIn = new System.Windows.Forms.ToolStripButton();
            this.tsbOut = new System.Windows.Forms.ToolStripButton();
            this.tsbStock = new System.Windows.Forms.ToolStripButton();
            this.tsWarehouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 721);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1162, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsWarehouse
            // 
            this.tsWarehouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIn,
            this.tsbOut,
            this.tsbStock});
            this.tsWarehouse.Location = new System.Drawing.Point(0, 0);
            this.tsWarehouse.Name = "tsWarehouse";
            this.tsWarehouse.Size = new System.Drawing.Size(1162, 25);
            this.tsWarehouse.TabIndex = 1;
            this.tsWarehouse.Text = "toolStrip1";
            // 
            // tsbIn
            // 
            this.tsbIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbIn.Image")));
            this.tsbIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIn.Name = "tsbIn";
            this.tsbIn.Size = new System.Drawing.Size(76, 22);
            this.tsbIn.Text = "入库管理";
            // 
            // tsbOut
            // 
            this.tsbOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbOut.Image")));
            this.tsbOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOut.Name = "tsbOut";
            this.tsbOut.Size = new System.Drawing.Size(76, 22);
            this.tsbOut.Text = "出库管理";
            // 
            // tsbStock
            // 
            this.tsbStock.Image = ((System.Drawing.Image)(resources.GetObject("tsbStock.Image")));
            this.tsbStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStock.Name = "tsbStock";
            this.tsbStock.Size = new System.Drawing.Size(76, 22);
            this.tsbStock.Text = "库存管理";
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1162, 743);
            this.Controls.Add(this.tsWarehouse);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWarehouse";
            this.Text = "仓库管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWarehouse_FormClosed);
            this.tsWarehouse.ResumeLayout(false);
            this.tsWarehouse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip tsWarehouse;
        private System.Windows.Forms.ToolStripButton tsbIn;
        private System.Windows.Forms.ToolStripButton tsbOut;
        private System.Windows.Forms.ToolStripButton tsbStock;
    }
}