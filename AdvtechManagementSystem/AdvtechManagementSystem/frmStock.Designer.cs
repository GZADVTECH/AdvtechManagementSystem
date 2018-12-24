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
            this.tsbInStock = new System.Windows.Forms.ToolStripButton();
            this.tssStock = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOutStock = new System.Windows.Forms.ToolStripButton();
            this.lbStock = new System.Windows.Forms.ListBox();
            this.rtbStock = new System.Windows.Forms.RichTextBox();
            this.gbSNID = new System.Windows.Forms.GroupBox();
            this.lStockName = new System.Windows.Forms.Label();
            this.lStockModal = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.txtStockModal = new System.Windows.Forms.TextBox();
            this.btnSNIn = new System.Windows.Forms.Button();
            this.btnSNOut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSNID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tsStock.SuspendLayout();
            this.gbSNID.SuspendLayout();
            this.gbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // 
            // tsbSelect
            // 
            this.tsbSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(23, 22);
            this.tsbSelect.Text = "toolStripButton1";
            this.tsbSelect.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // tsbInStock
            // 
            this.tsbInStock.Image = ((System.Drawing.Image)(resources.GetObject("tsbInStock.Image")));
            this.tsbInStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInStock.Name = "tsbInStock";
            this.tsbInStock.Size = new System.Drawing.Size(105, 22);
            this.tsbInStock.Text = "库存Excel导入";
            // 
            // tssStock
            // 
            this.tssStock.Name = "tssStock";
            this.tssStock.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOutStock
            // 
            this.tsbOutStock.Image = ((System.Drawing.Image)(resources.GetObject("tsbOutStock.Image")));
            this.tsbOutStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOutStock.Name = "tsbOutStock";
            this.tsbOutStock.Size = new System.Drawing.Size(105, 22);
            this.tsbOutStock.Text = "库存Excel导出";
            // 
            // lbStock
            // 
            this.lbStock.FormattingEnabled = true;
            this.lbStock.ItemHeight = 12;
            this.lbStock.Location = new System.Drawing.Point(13, 29);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(221, 580);
            this.lbStock.TabIndex = 1;
            // 
            // rtbStock
            // 
            this.rtbStock.Location = new System.Drawing.Point(240, 29);
            this.rtbStock.Name = "rtbStock";
            this.rtbStock.Size = new System.Drawing.Size(521, 115);
            this.rtbStock.TabIndex = 2;
            this.rtbStock.Text = "";
            // 
            // gbSNID
            // 
            this.gbSNID.Controls.Add(this.button1);
            this.gbSNID.Controls.Add(this.txtSNID);
            this.gbSNID.Controls.Add(this.label2);
            this.gbSNID.Controls.Add(this.label1);
            this.gbSNID.Controls.Add(this.listBox2);
            this.gbSNID.Controls.Add(this.listBox1);
            this.gbSNID.Controls.Add(this.btnSNOut);
            this.gbSNID.Controls.Add(this.btnSNIn);
            this.gbSNID.Controls.Add(this.txtStockModal);
            this.gbSNID.Controls.Add(this.txtStockName);
            this.gbSNID.Controls.Add(this.lStockModal);
            this.gbSNID.Controls.Add(this.lStockName);
            this.gbSNID.Location = new System.Drawing.Point(511, 151);
            this.gbSNID.Name = "gbSNID";
            this.gbSNID.Size = new System.Drawing.Size(250, 458);
            this.gbSNID.TabIndex = 3;
            this.gbSNID.TabStop = false;
            this.gbSNID.Text = "S/N码";
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
            // lStockModal
            // 
            this.lStockModal.AutoSize = true;
            this.lStockModal.Location = new System.Drawing.Point(13, 50);
            this.lStockModal.Name = "lStockModal";
            this.lStockModal.Size = new System.Drawing.Size(41, 12);
            this.lStockModal.TabIndex = 0;
            this.lStockModal.Text = "型号：";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(60, 20);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.ReadOnly = true;
            this.txtStockName.Size = new System.Drawing.Size(183, 21);
            this.txtStockName.TabIndex = 1;
            // 
            // txtStockModal
            // 
            this.txtStockModal.Location = new System.Drawing.Point(60, 47);
            this.txtStockModal.Name = "txtStockModal";
            this.txtStockModal.ReadOnly = true;
            this.txtStockModal.Size = new System.Drawing.Size(183, 21);
            this.txtStockModal.TabIndex = 1;
            // 
            // btnSNIn
            // 
            this.btnSNIn.Location = new System.Drawing.Point(6, 74);
            this.btnSNIn.Name = "btnSNIn";
            this.btnSNIn.Size = new System.Drawing.Size(75, 23);
            this.btnSNIn.TabIndex = 2;
            this.btnSNIn.Text = "Excel导入";
            this.btnSNIn.UseVisualStyleBackColor = true;
            // 
            // btnSNOut
            // 
            this.btnSNOut.Location = new System.Drawing.Point(168, 74);
            this.btnSNOut.Name = "btnSNOut";
            this.btnSNOut.Size = new System.Drawing.Size(75, 23);
            this.btnSNOut.TabIndex = 2;
            this.btnSNOut.Text = "Excel导出";
            this.btnSNOut.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(113, 292);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(130, 127);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(113, 292);
            this.listBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "已保存的S/N码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "正在进行操作的S/N码";
            // 
            // txtSNID
            // 
            this.txtSNID.Location = new System.Drawing.Point(6, 425);
            this.txtSNID.Name = "txtSNID";
            this.txtSNID.Size = new System.Drawing.Size(237, 21);
            this.txtSNID.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.button2);
            this.gbStock.Controls.Add(this.richTextBox1);
            this.gbStock.Controls.Add(this.comboBox2);
            this.gbStock.Controls.Add(this.comboBox1);
            this.gbStock.Controls.Add(this.textBox4);
            this.gbStock.Controls.Add(this.textBox3);
            this.gbStock.Controls.Add(this.numericUpDown1);
            this.gbStock.Controls.Add(this.label10);
            this.gbStock.Controls.Add(this.label9);
            this.gbStock.Controls.Add(this.label8);
            this.gbStock.Controls.Add(this.textBox2);
            this.gbStock.Controls.Add(this.textBox1);
            this.gbStock.Controls.Add(this.label7);
            this.gbStock.Controls.Add(this.label6);
            this.gbStock.Controls.Add(this.label5);
            this.gbStock.Controls.Add(this.label4);
            this.gbStock.Controls.Add(this.label3);
            this.gbStock.Location = new System.Drawing.Point(240, 151);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(265, 457);
            this.gbStock.TabIndex = 4;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "相关信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "名称：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "型号：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 21);
            this.textBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "采购价格：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "销售价格：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "存放位置：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "单位：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "备注：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(79, 87);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 21);
            this.numericUpDown1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 21);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 21);
            this.textBox4.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(210, 188);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(49, 20);
            this.comboBox2.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(79, 223);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(180, 194);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "如需标注是否含税，请在此处填写（例:采购价格不含税，销售价格含税）";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "提交";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 620);
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
            this.tsStock.ResumeLayout(false);
            this.tsStock.PerformLayout();
            this.gbSNID.ResumeLayout(false);
            this.gbSNID.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSNID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSNOut;
        private System.Windows.Forms.Button btnSNIn;
        private System.Windows.Forms.TextBox txtStockModal;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label lStockModal;
        private System.Windows.Forms.Label lStockName;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}