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
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbPayType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvPay = new System.Windows.Forms.DataGridView();
            this.btPayDetail = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPay)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(206, 10);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(218, 24);
            this.txtCusName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(203, 13);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(218, 24);
            this.txtAddress.TabIndex = 0;
            // 
            // cbPayType
            // 
            this.cbPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPayType.FormattingEnabled = true;
            this.cbPayType.Items.AddRange(new object[] {
            "Theo tên khách hàng",
            "Theo mã phòng"});
            this.cbPayType.Location = new System.Drawing.Point(206, 13);
            this.cbPayType.Name = "cbPayType";
            this.cbPayType.Size = new System.Drawing.Size(218, 26);
            this.cbPayType.TabIndex = 2;
            this.cbPayType.SelectedValueChanged += new System.EventHandler(this.cbPayType_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hình thức thanh toán";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbData);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(3, 221);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(433, 48);
            this.panel7.TabIndex = 5;
            // 
            // cbData
            // 
            this.cbData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(206, 13);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(218, 26);
            this.cbData.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chọn dữ liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách hàng/Cơ quan";
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btAdd.Location = new System.Drawing.Point(320, 285);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(110, 31);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbPayType);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(3, 148);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(433, 48);
            this.panel6.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 334);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Location = new System.Drawing.Point(6, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 42);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtCusName);
            this.panel3.Location = new System.Drawing.Point(3, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 48);
            this.panel3.TabIndex = 1;
            // 
            // dtgvPay
            // 
            this.dtgvPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPay.Location = new System.Drawing.Point(3, 12);
            this.dtgvPay.Name = "dtgvPay";
            this.dtgvPay.Size = new System.Drawing.Size(476, 245);
            this.dtgvPay.TabIndex = 0;
            // 
            // btPayDetail
            // 
            this.btPayDetail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btPayDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPayDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPayDetail.Location = new System.Drawing.Point(848, 283);
            this.btPayDetail.Name = "btPayDetail";
            this.btPayDetail.Size = new System.Drawing.Size(110, 40);
            this.btPayDetail.TabIndex = 5;
            this.btPayDetail.Text = "Chi tiết hóa đơn";
            this.btPayDetail.UseVisualStyleBackColor = false;
            this.btPayDetail.Click += new System.EventHandler(this.btPayDetail_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvPay);
            this.panel5.Location = new System.Drawing.Point(479, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 266);
            this.panel5.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btPayDetail);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 369);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(848, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fPayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 371);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "fPayInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPayInfo";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPay)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbPayType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvPay;
        private System.Windows.Forms.Button btPayDetail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}