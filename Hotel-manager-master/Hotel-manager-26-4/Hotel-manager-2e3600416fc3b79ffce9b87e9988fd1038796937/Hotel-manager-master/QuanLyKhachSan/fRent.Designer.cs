namespace QuanLyKhachSan
{
    partial class fRent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxFormality = new System.Windows.Forms.ComboBox();
            this.txbRoomName = new System.Windows.Forms.TextBox();
            this.dtBeginRent = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvInputCustomes = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerStyle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInputCustomes)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(300, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẬP PHIẾU THUÊ PHÒNG";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxFormality);
            this.panel2.Controls.Add(this.txbRoomName);
            this.panel2.Controls.Add(this.dtBeginRent);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 56);
            this.panel2.TabIndex = 0;
            // 
            // cbxFormality
            // 
            this.cbxFormality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormality.FormattingEnabled = true;
            this.cbxFormality.Location = new System.Drawing.Point(392, 17);
            this.cbxFormality.Name = "cbxFormality";
            this.cbxFormality.Size = new System.Drawing.Size(157, 28);
            this.cbxFormality.TabIndex = 2;
            this.cbxFormality.SelectedIndexChanged += new System.EventHandler(this.cbxFormality_SelectedIndexChanged);
            // 
            // txbRoomName
            // 
            this.txbRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRoomName.Location = new System.Drawing.Point(97, 17);
            this.txbRoomName.Name = "txbRoomName";
            this.txbRoomName.Size = new System.Drawing.Size(132, 26);
            this.txbRoomName.TabIndex = 1;
            // 
            // dtBeginRent
            // 
            this.dtBeginRent.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtBeginRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBeginRent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBeginRent.Location = new System.Drawing.Point(724, 21);
            this.dtBeginRent.Name = "dtBeginRent";
            this.dtBeginRent.Size = new System.Drawing.Size(293, 26);
            this.dtBeginRent.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày bắt đầu thuê : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hình thức thuê :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Phòng :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvInputCustomes);
            this.panel3.Location = new System.Drawing.Point(13, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1052, 253);
            this.panel3.TabIndex = 0;
            // 
            // dtgvInputCustomes
            // 
            this.dtgvInputCustomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvInputCustomes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInputCustomes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvInputCustomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInputCustomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.customerStyle,
            this.customerCMND,
            this.customerAddress});
            this.dtgvInputCustomes.Location = new System.Drawing.Point(0, 3);
            this.dtgvInputCustomes.Name = "dtgvInputCustomes";
            this.dtgvInputCustomes.RowHeadersWidth = 40;
            this.dtgvInputCustomes.Size = new System.Drawing.Size(1049, 247);
            this.dtgvInputCustomes.TabIndex = 0;
            // 
            // customerName
            // 
            this.customerName.FillWeight = 60F;
            this.customerName.HeaderText = "Tên Khách Hàng";
            this.customerName.Name = "customerName";
            // 
            // customerStyle
            // 
            this.customerStyle.FillWeight = 40F;
            this.customerStyle.HeaderText = "Loại Khách";
            this.customerStyle.Name = "customerStyle";
            this.customerStyle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerStyle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // customerCMND
            // 
            this.customerCMND.FillWeight = 45F;
            this.customerCMND.HeaderText = "CMND ";
            this.customerCMND.Name = "customerCMND";
            // 
            // customerAddress
            // 
            this.customerAddress.HeaderText = "Địa chỉ";
            this.customerAddress.Name = "customerAddress";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAccept);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Location = new System.Drawing.Point(13, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1052, 108);
            this.panel4.TabIndex = 0;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccept.Location = new System.Drawing.Point(73, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(156, 87);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Thuê";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(818, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 87);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Trở về";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1068, 502);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê phòng";
            this.Load += new System.EventHandler(this.fRent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInputCustomes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbRoomName;
        private System.Windows.Forms.DateTimePicker dtBeginRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dtgvInputCustomes;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cbxFormality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
    }
}