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
            this.button2 = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPayDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(238, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 57);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvPayDetail);
            this.panel2.Location = new System.Drawing.Point(2, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 304);
            this.panel2.TabIndex = 17;
            // 
            // dtgvPayDetail
            // 
            this.dtgvPayDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPayDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvPayDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPayDetail.Location = new System.Drawing.Point(10, 8);
            this.dtgvPayDetail.Name = "dtgvPayDetail";
            this.dtgvPayDetail.ReadOnly = true;
            this.dtgvPayDetail.Size = new System.Drawing.Size(761, 293);
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
            this.panel3.Location = new System.Drawing.Point(2, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 98);
            this.panel3.TabIndex = 14;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(528, 63);
            this.txbTotalPrice.Multiline = true;
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(243, 32);
            this.txbTotalPrice.TabIndex = 2;
            // 
            // txbReadAddress
            // 
            this.txbReadAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trị giá :";
            // 
            // txbReadNameCus
            // 
            this.txbReadNameCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReadNameCus.Location = new System.Drawing.Point(190, 11);
            this.txbReadNameCus.Name = "txbReadNameCus";
            this.txbReadNameCus.ReadOnly = true;
            this.txbReadNameCus.Size = new System.Drawing.Size(213, 29);
            this.txbReadNameCus.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng / Cơ quan : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(44, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xuất hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(434, 484);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(349, 59);
            this.panel6.TabIndex = 15;
            // 
            // fPayDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Name = "fPayDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPayDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPayDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
    }
}