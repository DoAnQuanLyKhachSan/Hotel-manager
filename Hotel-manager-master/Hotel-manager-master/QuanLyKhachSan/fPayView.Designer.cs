namespace QuanLyKhachSan
{
    partial class fPayView
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
            this.txbCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btPayView = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 48);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbCusName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 48);
            this.panel2.TabIndex = 3;
            // 
            // txbCusName
            // 
            this.txbCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCusName.Location = new System.Drawing.Point(232, 8);
            this.txbCusName.Name = "txbCusName";
            this.txbCusName.Size = new System.Drawing.Size(282, 26);
            this.txbCusName.TabIndex = 0;
            this.txbCusName.TextChanged += new System.EventHandler(this.txbCusName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tên khách hàng/Cơ quan : ";
            // 
            // btPayView
            // 
            this.btPayView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btPayView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPayView.Location = new System.Drawing.Point(278, 135);
            this.btPayView.Name = "btPayView";
            this.btPayView.Size = new System.Drawing.Size(150, 40);
            this.btPayView.TabIndex = 5;
            this.btPayView.Text = "Chi tiết thanh toán";
            this.btPayView.UseVisualStyleBackColor = false;
            this.btPayView.Click += new System.EventHandler(this.btPayView_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(658, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbAddress);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(535, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 48);
            this.panel3.TabIndex = 6;
            // 
            // cbAddress
            // 
            this.cbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(68, 11);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(282, 23);
            this.cbAddress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ : ";
            // 
            // fPayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 189);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btPayView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Name = "fPayView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPayView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPayView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.Label label3;
    }
}