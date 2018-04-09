namespace QuanLyKhachSan
{
    partial class fEditRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvPhong = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxRoomStatusNew = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxRoomStyleNew = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbRoomNoteNew = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbRoomNameNew = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtRoomCodeNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRoomCodeOld = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA PHÒNG";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mã phòng muốn sửa :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txbRoomCodeOld);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 270);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvPhong);
            this.panel5.Location = new System.Drawing.Point(344, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(546, 255);
            this.panel5.TabIndex = 4;
            // 
            // dtgvPhong
            // 
            this.dtgvPhong.AllowUserToAddRows = false;
            this.dtgvPhong.AllowUserToDeleteRows = false;
            this.dtgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhong.Location = new System.Drawing.Point(3, 3);
            this.dtgvPhong.Name = "dtgvPhong";
            this.dtgvPhong.ReadOnly = true;
            this.dtgvPhong.Size = new System.Drawing.Size(540, 249);
            this.dtgvPhong.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(3, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 217);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbxRoomStatusNew);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(11, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 33);
            this.panel6.TabIndex = 0;
            // 
            // cbxRoomStatusNew
            // 
            this.cbxRoomStatusNew.FormattingEnabled = true;
            this.cbxRoomStatusNew.Location = new System.Drawing.Point(137, 6);
            this.cbxRoomStatusNew.Name = "cbxRoomStatusNew";
            this.cbxRoomStatusNew.Size = new System.Drawing.Size(155, 21);
            this.cbxRoomStatusNew.TabIndex = 1;
            this.cbxRoomStatusNew.SelectedIndexChanged += new System.EventHandler(this.cbxRoomStatusNew_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình trạng phòng mới : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxRoomStyleNew);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(11, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 33);
            this.panel2.TabIndex = 0;
            // 
            // cbxRoomStyleNew
            // 
            this.cbxRoomStyleNew.FormattingEnabled = true;
            this.cbxRoomStyleNew.Location = new System.Drawing.Point(137, 6);
            this.cbxRoomStyleNew.Name = "cbxRoomStyleNew";
            this.cbxRoomStyleNew.Size = new System.Drawing.Size(155, 21);
            this.cbxRoomStyleNew.TabIndex = 1;
            this.cbxRoomStyleNew.SelectedIndexChanged += new System.EventHandler(this.cbxRoomStyleNew_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại Phòng mới :";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbRoomNoteNew);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(11, 128);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(297, 33);
            this.panel9.TabIndex = 0;
            // 
            // txbRoomNoteNew
            // 
            this.txbRoomNoteNew.BackColor = System.Drawing.SystemColors.Window;
            this.txbRoomNoteNew.Location = new System.Drawing.Point(137, 6);
            this.txbRoomNoteNew.Name = "txbRoomNoteNew";
            this.txbRoomNoteNew.Size = new System.Drawing.Size(155, 20);
            this.txbRoomNoteNew.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ghi chú mới ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbRoomNameNew);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(11, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(297, 33);
            this.panel8.TabIndex = 0;
            // 
            // txbRoomNameNew
            // 
            this.txbRoomNameNew.BackColor = System.Drawing.SystemColors.Window;
            this.txbRoomNameNew.Location = new System.Drawing.Point(137, 6);
            this.txbRoomNameNew.Name = "txbRoomNameNew";
            this.txbRoomNameNew.Size = new System.Drawing.Size(155, 20);
            this.txbRoomNameNew.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên phòng mới : ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtRoomCodeNew);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(11, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(297, 33);
            this.panel7.TabIndex = 0;
            // 
            // txtRoomCodeNew
            // 
            this.txtRoomCodeNew.BackColor = System.Drawing.SystemColors.Window;
            this.txtRoomCodeNew.Location = new System.Drawing.Point(137, 6);
            this.txtRoomCodeNew.Name = "txtRoomCodeNew";
            this.txtRoomCodeNew.Size = new System.Drawing.Size(155, 20);
            this.txtRoomCodeNew.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã phòng mới : ";
            // 
            // txbRoomCodeOld
            // 
            this.txbRoomCodeOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRoomCodeOld.Location = new System.Drawing.Point(220, 12);
            this.txbRoomCodeOld.Name = "txbRoomCodeOld";
            this.txbRoomCodeOld.Size = new System.Drawing.Size(86, 26);
            this.txbRoomCodeOld.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(723, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // fEditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fEditRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin phòng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbRoomCodeOld;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbxRoomStatusNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtRoomCodeNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxRoomStyleNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvPhong;
        private System.Windows.Forms.TextBox txbRoomNoteNew;
        private System.Windows.Forms.TextBox txbRoomNameNew;
    }
}