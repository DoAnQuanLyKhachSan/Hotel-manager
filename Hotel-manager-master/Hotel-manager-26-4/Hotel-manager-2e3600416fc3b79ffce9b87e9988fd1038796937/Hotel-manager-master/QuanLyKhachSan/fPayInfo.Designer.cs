namespace QuanLyKhachSan
{
    partial class fPayInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPayInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btCreatePay = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpPay = new System.Windows.Forms.DateTimePicker();
            this.txbPayID = new System.Windows.Forms.TextBox();
            this.lbPayID = new System.Windows.Forms.Label();
            this.dtgvPay = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbListRentID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPay)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btCreatePay);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 439);
            this.panel1.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(830, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 87);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quay lại";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCreatePay
            // 
            this.btCreatePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.btCreatePay.FlatAppearance.BorderSize = 0;
            this.btCreatePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreatePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreatePay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCreatePay.Image = ((System.Drawing.Image)(resources.GetObject("btCreatePay.Image")));
            this.btCreatePay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCreatePay.Location = new System.Drawing.Point(529, 340);
            this.btCreatePay.Name = "btCreatePay";
            this.btCreatePay.Size = new System.Drawing.Size(173, 87);
            this.btCreatePay.TabIndex = 2;
            this.btCreatePay.Text = "Tạo phiếu thanh toán";
            this.btCreatePay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCreatePay.UseVisualStyleBackColor = false;
            this.btCreatePay.Click += new System.EventHandler(this.btCreatePay_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.dtpPay);
            this.panel5.Controls.Add(this.txbPayID);
            this.panel5.Controls.Add(this.lbPayID);
            this.panel5.Controls.Add(this.dtgvPay);
            this.panel5.Location = new System.Drawing.Point(469, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 266);
            this.panel5.TabIndex = 1;
            // 
            // dtpPay
            // 
            this.dtpPay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPay.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtpPay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPay.Location = new System.Drawing.Point(238, 13);
            this.dtpPay.Name = "dtpPay";
            this.dtpPay.Size = new System.Drawing.Size(265, 20);
            this.dtpPay.TabIndex = 2;
            // 
            // txbPayID
            // 
            this.txbPayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPayID.Location = new System.Drawing.Point(92, 10);
            this.txbPayID.Name = "txbPayID";
            this.txbPayID.ReadOnly = true;
            this.txbPayID.Size = new System.Drawing.Size(100, 26);
            this.txbPayID.TabIndex = 1;
            // 
            // lbPayID
            // 
            this.lbPayID.AutoSize = true;
            this.lbPayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayID.Location = new System.Drawing.Point(23, 16);
            this.lbPayID.Name = "lbPayID";
            this.lbPayID.Size = new System.Drawing.Size(63, 20);
            this.lbPayID.TabIndex = 8;
            this.lbPayID.Text = "Mã HD:";
            // 
            // dtgvPay
            // 
            this.dtgvPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvPay.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPay.Location = new System.Drawing.Point(3, 46);
            this.dtgvPay.Name = "dtgvPay";
            this.dtgvPay.Size = new System.Drawing.Size(529, 211);
            this.dtgvPay.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 368);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbListRentID);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(9, 202);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(433, 48);
            this.panel7.TabIndex = 3;
            // 
            // cbListRentID
            // 
            this.cbListRentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbListRentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbListRentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbListRentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListRentID.FormattingEnabled = true;
            this.cbListRentID.Location = new System.Drawing.Point(206, 13);
            this.cbListRentID.Name = "cbListRentID";
            this.cbListRentID.Size = new System.Drawing.Size(218, 28);
            this.cbListRentID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách phiếu thuê :";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdd.Location = new System.Drawing.Point(289, 272);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(144, 87);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Chọn";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txbAddress);
            this.panel4.Location = new System.Drawing.Point(9, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 47);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ :";
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(206, 8);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(218, 26);
            this.txbAddress.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbCusName);
            this.panel3.Location = new System.Drawing.Point(9, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 48);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách hàng/Cơ quan :";
            // 
            // txbCusName
            // 
            this.txbCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCusName.Location = new System.Drawing.Point(206, 10);
            this.txbCusName.Name = "txbCusName";
            this.txbCusName.Size = new System.Drawing.Size(218, 26);
            this.txbCusName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(312, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lập phiếu thanh toán";
            // 
            // fPayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1017, 443);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPayInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPayInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fPayInfo_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCreatePay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpPay;
        private System.Windows.Forms.TextBox txbPayID;
        private System.Windows.Forms.Label lbPayID;
        private System.Windows.Forms.DataGridView dtgvPay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbListRentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCusName;
        private System.Windows.Forms.Label label3;
    }
}