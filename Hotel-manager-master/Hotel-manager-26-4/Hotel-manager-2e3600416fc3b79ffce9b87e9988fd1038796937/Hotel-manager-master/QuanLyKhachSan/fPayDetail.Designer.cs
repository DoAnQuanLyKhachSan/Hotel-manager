namespace QuanLyKhachSan
{
    partial class fPayDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPayDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvPayDetail = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.txbReadAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbReadNameCus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btPrintPay = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPayDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 47);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(145, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvPayDetail);
            this.panel2.Location = new System.Drawing.Point(2, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 248);
            this.panel2.TabIndex = 25;
            // 
            // dtgvPayDetail
            // 
            this.dtgvPayDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPayDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvPayDetail.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPayDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPayDetail.Location = new System.Drawing.Point(10, 8);
            this.dtgvPayDetail.Name = "dtgvPayDetail";
            this.dtgvPayDetail.ReadOnly = true;
            this.dtgvPayDetail.Size = new System.Drawing.Size(761, 234);
            this.dtgvPayDetail.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.txbReadAddress);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbReadNameCus);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(2, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 98);
            this.panel3.TabIndex = 22;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbTotalPrice.Location = new System.Drawing.Point(528, 63);
            this.txbTotalPrice.Multiline = true;
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(243, 32);
            this.txbTotalPrice.TabIndex = 2;
            // 
            // txbReadAddress
            // 
            this.txbReadAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbReadAddress.Location = new System.Drawing.Point(528, 11);
            this.txbReadAddress.Multiline = true;
            this.txbReadAddress.Name = "txbReadAddress";
            this.txbReadAddress.ReadOnly = true;
            this.txbReadAddress.Size = new System.Drawing.Size(243, 32);
            this.txbReadAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(445, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trị giá :";
            // 
            // txbReadNameCus
            // 
            this.txbReadNameCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbReadNameCus.Location = new System.Drawing.Point(190, 11);
            this.txbReadNameCus.Name = "txbReadNameCus";
            this.txbReadNameCus.ReadOnly = true;
            this.txbReadNameCus.Size = new System.Drawing.Size(213, 26);
            this.txbReadNameCus.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(446, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng / Cơ quan : ";
            // 
            // btPrintPay
            // 
            this.btPrintPay.BackColor = System.Drawing.Color.Red;
            this.btPrintPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintPay.ForeColor = System.Drawing.Color.Yellow;
            this.btPrintPay.Location = new System.Drawing.Point(85, 442);
            this.btPrintPay.Name = "btPrintPay";
            this.btPrintPay.Size = new System.Drawing.Size(144, 87);
            this.btPrintPay.TabIndex = 2;
            this.btPrintPay.Text = "Xuất hóa đơn";
            this.btPrintPay.UseVisualStyleBackColor = false;
            this.btPrintPay.Click += new System.EventHandler(this.btPrintPay_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(578, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 87);
            this.button1.TabIndex = 26;
            this.button1.Text = "Quay lại";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fPayDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(788, 559);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btPrintPay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPayDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPayDetail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fPayDetail_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPayDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvPayDetail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.TextBox txbReadAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbReadNameCus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPrintPay;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
    }
}