namespace QuanLyKhachSan
{
    partial class fService
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.cbListRentID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvHistoryService = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btAccept = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpUseService = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbListNameCus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbListService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistoryService)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 521);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btBack);
            this.panel3.Controls.Add(this.cbListRentID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 431);
            this.panel3.TabIndex = 1;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(862, 350);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(112, 31);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Trở về";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // cbListRentID
            // 
            this.cbListRentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListRentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListRentID.FormattingEnabled = true;
            this.cbListRentID.Location = new System.Drawing.Point(267, 27);
            this.cbListRentID.Name = "cbListRentID";
            this.cbListRentID.Size = new System.Drawing.Size(88, 26);
            this.cbListRentID.TabIndex = 0;
            this.cbListRentID.SelectedValueChanged += new System.EventHandler(this.cbListRentID_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn phiếu thuê sử dung dịch vụ :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvHistoryService);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(377, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(614, 338);
            this.panel5.TabIndex = 2;
            // 
            // dtgvHistoryService
            // 
            this.dtgvHistoryService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHistoryService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistoryService.Location = new System.Drawing.Point(6, 60);
            this.dtgvHistoryService.Name = "dtgvHistoryService";
            this.dtgvHistoryService.Size = new System.Drawing.Size(605, 266);
            this.dtgvHistoryService.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(182, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lịch Sử Sử Dụng Dịch Vụ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btAccept);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(7, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 317);
            this.panel4.TabIndex = 1;
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(247, 274);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(98, 31);
            this.btAccept.TabIndex = 4;
            this.btAccept.Text = "Xác nhận";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbCount);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(6, 223);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(350, 33);
            this.panel9.TabIndex = 3;
            // 
            // txbCount
            // 
            this.txbCount.BackColor = System.Drawing.SystemColors.Window;
            this.txbCount.Location = new System.Drawing.Point(151, 6);
            this.txbCount.Name = "txbCount";
            this.txbCount.Size = new System.Drawing.Size(191, 20);
            this.txbCount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.dtpUseService);
            this.panel8.Location = new System.Drawing.Point(6, 18);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(347, 37);
            this.panel8.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày giờ sử dụng";
            // 
            // dtpUseService
            // 
            this.dtpUseService.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpUseService.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtpUseService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUseService.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUseService.Location = new System.Drawing.Point(154, 9);
            this.dtpUseService.Name = "dtpUseService";
            this.dtpUseService.Size = new System.Drawing.Size(188, 20);
            this.dtpUseService.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbListNameCus);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(6, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(347, 33);
            this.panel6.TabIndex = 1;
            // 
            // cbListNameCus
            // 
            this.cbListNameCus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListNameCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbListNameCus.FormattingEnabled = true;
            this.cbListNameCus.Location = new System.Drawing.Point(154, 6);
            this.cbListNameCus.Name = "cbListNameCus";
            this.cbListNameCus.Size = new System.Drawing.Size(188, 21);
            this.cbListNameCus.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách hàng sử dụng";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbListService);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(6, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(347, 33);
            this.panel7.TabIndex = 2;
            // 
            // cbListService
            // 
            this.cbListService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbListService.FormattingEnabled = true;
            this.cbListService.Location = new System.Drawing.Point(151, 6);
            this.cbListService.Name = "cbListService";
            this.cbListService.Size = new System.Drawing.Size(188, 21);
            this.cbListService.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn dịch vụ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(207, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 68);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(179, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 36);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sử Dụng Dịch Vụ";
            // 
            // fService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 529);
            this.Controls.Add(this.panel1);
            this.Name = "fService";
            this.Text = "fService";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistoryService)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbListNameCus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpUseService;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbListService;
        private System.Windows.Forms.DataGridView dtgvHistoryService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.ComboBox cbListRentID;
        private System.Windows.Forms.Button btBack;
    }
}