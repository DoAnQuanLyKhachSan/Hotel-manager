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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btCreatePay);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 369);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(882, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCreatePay
            // 
            this.btCreatePay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCreatePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreatePay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCreatePay.Location = new System.Drawing.Point(882, 281);
            this.btCreatePay.Name = "btCreatePay";
            this.btCreatePay.Size = new System.Drawing.Size(110, 40);
            this.btCreatePay.TabIndex = 2;
            this.btCreatePay.Text = "Tạo hóa đơn";
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
            this.panel5.Location = new System.Drawing.Point(469, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 266);
            this.panel5.TabIndex = 1;
            // 
            // dtpPay
            // 
            this.dtpPay.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtpPay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPay.Location = new System.Drawing.Point(238, 13);
            this.dtpPay.Name = "dtpPay";
            this.dtpPay.Size = new System.Drawing.Size(265, 20);
            this.dtpPay.TabIndex = 2;
            // 
            // txbPayID
            // 
            this.txbPayID.Location = new System.Drawing.Point(73, 13);
            this.txbPayID.Name = "txbPayID";
            this.txbPayID.ReadOnly = true;
            this.txbPayID.Size = new System.Drawing.Size(100, 20);
            this.txbPayID.TabIndex = 1;
            // 
            // lbPayID
            // 
            this.lbPayID.AutoSize = true;
            this.lbPayID.Location = new System.Drawing.Point(23, 16);
            this.lbPayID.Name = "lbPayID";
            this.lbPayID.Size = new System.Drawing.Size(44, 13);
            this.lbPayID.TabIndex = 8;
            this.lbPayID.Text = "Mã HD:";
            // 
            // dtgvPay
            // 
            this.dtgvPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 334);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbListRentID);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(3, 203);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(433, 48);
            this.panel7.TabIndex = 3;
            // 
            // cbListRentID
            // 
            this.cbListRentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbListRentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbListRentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbListRentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListRentID.FormattingEnabled = true;
            this.cbListRentID.Location = new System.Drawing.Point(212, 13);
            this.cbListRentID.Name = "cbListRentID";
            this.cbListRentID.Size = new System.Drawing.Size(212, 26);
            this.cbListRentID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách phiếu thuê";
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btAdd.Location = new System.Drawing.Point(317, 280);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(110, 31);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Chọn";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txbAddress);
            this.panel4.Location = new System.Drawing.Point(9, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 47);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
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
            this.panel3.Location = new System.Drawing.Point(9, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 48);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách hàng/Cơ quan";
            // 
            // txbCusName
            // 
            this.txbCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCusName.Location = new System.Drawing.Point(206, 10);
            this.txbCusName.Name = "txbCusName";
            this.txbCusName.Size = new System.Drawing.Size(218, 26);
            this.txbCusName.TabIndex = 0;
            // 
            // fPayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 374);
            this.Controls.Add(this.panel1);
            this.Name = "fPayInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPayInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fPayInfo_FormClosed);
            this.panel1.ResumeLayout(false);
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
    }
}