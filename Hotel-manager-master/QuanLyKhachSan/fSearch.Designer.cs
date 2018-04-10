namespace QuanLyKhachSan
{
    partial class fSearch
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusRoomSearch = new System.Windows.Forms.Button();
            this.styleRoomSearch = new System.Windows.Forms.Button();
            this.codeRoomSearch = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxRoomStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbxStyleRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgvDataRoom = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU THÔNG TIN PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusRoomSearch);
            this.panel2.Controls.Add(this.styleRoomSearch);
            this.panel2.Controls.Add(this.codeRoomSearch);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 233);
            this.panel2.TabIndex = 1;
            // 
            // statusRoomSearch
            // 
            this.statusRoomSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusRoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusRoomSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusRoomSearch.Location = new System.Drawing.Point(279, 143);
            this.statusRoomSearch.Name = "statusRoomSearch";
            this.statusRoomSearch.Size = new System.Drawing.Size(59, 51);
            this.statusRoomSearch.TabIndex = 2;
            this.statusRoomSearch.Text = "Tìm Kiếm";
            this.statusRoomSearch.UseVisualStyleBackColor = false;
            this.statusRoomSearch.Click += new System.EventHandler(this.statusRoomSearch_Click);
            // 
            // styleRoomSearch
            // 
            this.styleRoomSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.styleRoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleRoomSearch.Location = new System.Drawing.Point(279, 70);
            this.styleRoomSearch.Name = "styleRoomSearch";
            this.styleRoomSearch.Size = new System.Drawing.Size(59, 51);
            this.styleRoomSearch.TabIndex = 2;
            this.styleRoomSearch.Text = "Tìm Kiếm";
            this.styleRoomSearch.UseVisualStyleBackColor = false;
            this.styleRoomSearch.Click += new System.EventHandler(this.styleRoomSearch_Click_1);
            // 
            // codeRoomSearch
            // 
            this.codeRoomSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.codeRoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeRoomSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.codeRoomSearch.Location = new System.Drawing.Point(279, 3);
            this.codeRoomSearch.Name = "codeRoomSearch";
            this.codeRoomSearch.Size = new System.Drawing.Size(59, 51);
            this.codeRoomSearch.TabIndex = 1;
            this.codeRoomSearch.Text = "Tìm Kiếm";
            this.codeRoomSearch.UseVisualStyleBackColor = false;
            this.codeRoomSearch.Click += new System.EventHandler(this.codeRoomSearch_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbxRoomStatus);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(11, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 33);
            this.panel6.TabIndex = 0;
            // 
            // cbxRoomStatus
            // 
            this.cbxRoomStatus.FormattingEnabled = true;
            this.cbxRoomStatus.Location = new System.Drawing.Point(107, 6);
            this.cbxRoomStatus.Name = "cbxRoomStatus";
            this.cbxRoomStatus.Size = new System.Drawing.Size(155, 21);
            this.cbxRoomStatus.TabIndex = 1;
            this.cbxRoomStatus.SelectedIndexChanged += new System.EventHandler(this.cbxRoomStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình Trạng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbxStyleRoom);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(11, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 33);
            this.panel5.TabIndex = 0;
            // 
            // cbxStyleRoom
            // 
            this.cbxStyleRoom.FormattingEnabled = true;
            this.cbxStyleRoom.Location = new System.Drawing.Point(107, 6);
            this.cbxStyleRoom.Name = "cbxStyleRoom";
            this.cbxStyleRoom.Size = new System.Drawing.Size(155, 21);
            this.cbxStyleRoom.TabIndex = 1;
            this.cbxStyleRoom.SelectedIndexChanged += new System.EventHandler(this.cbxStyleRoom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại Phòng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbRoom);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(11, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 33);
            this.panel4.TabIndex = 0;
            // 
            // txbRoom
            // 
            this.txbRoom.BackColor = System.Drawing.SystemColors.Window;
            this.txbRoom.Location = new System.Drawing.Point(107, 6);
            this.txbRoom.Name = "txbRoom";
            this.txbRoom.Size = new System.Drawing.Size(155, 20);
            this.txbRoom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(693, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgvDataRoom
            // 
            this.dtgvDataRoom.AllowUserToAddRows = false;
            this.dtgvDataRoom.AllowUserToDeleteRows = false;
            this.dtgvDataRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDataRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataRoom.Location = new System.Drawing.Point(350, 67);
            this.dtgvDataRoom.Name = "dtgvDataRoom";
            this.dtgvDataRoom.ReadOnly = true;
            this.dtgvDataRoom.Size = new System.Drawing.Size(519, 233);
            this.dtgvDataRoom.TabIndex = 0;
            // 
            // fSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 366);
            this.Controls.Add(this.dtgvDataRoom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu phòng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbxRoomStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbxStyleRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button codeRoomSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgvDataRoom;
        private System.Windows.Forms.Button statusRoomSearch;
        private System.Windows.Forms.Button styleRoomSearch;
    }
}