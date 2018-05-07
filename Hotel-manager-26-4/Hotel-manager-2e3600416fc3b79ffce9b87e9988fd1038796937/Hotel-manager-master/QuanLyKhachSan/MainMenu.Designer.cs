using System;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.flpStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AboutUsButton = new System.Windows.Forms.Button();
            this.ChangeRegulationButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.PayButton = new System.Windows.Forms.Button();
            this.RoomButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(254, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpRoom.Location = new System.Drawing.Point(251, 132);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(658, 506);
            this.flpRoom.TabIndex = 5;
            this.flpRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.flpRoom_Paint);
            // 
            // flpStatus
            // 
            this.flpStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flpStatus.Location = new System.Drawing.Point(251, 75);
            this.flpStatus.Name = "flpStatus";
            this.flpStatus.Size = new System.Drawing.Size(658, 60);
            this.flpStatus.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.AboutUsButton);
            this.panel2.Controls.Add(this.ChangeRegulationButton);
            this.panel2.Controls.Add(this.ReportButton);
            this.panel2.Controls.Add(this.PayButton);
            this.panel2.Controls.Add(this.RoomButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 641);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::QuanLyKhachSan.Properties.Resources.icons8_food_26;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(3, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 63);
            this.button3.TabIndex = 0;
            this.button3.Text = "Dịch vụ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Image = global::QuanLyKhachSan.Properties.Resources.person;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(3, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 64);
            this.button5.TabIndex = 1;
            this.button5.Text = "Nhân Viên";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Location = new System.Drawing.Point(3, 574);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(242, 64);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 69);
            this.panel3.TabIndex = 17;
            // 
            // AboutUsButton
            // 
            this.AboutUsButton.FlatAppearance.BorderSize = 0;
            this.AboutUsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AboutUsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUsButton.ForeColor = System.Drawing.Color.Black;
            this.AboutUsButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutUsButton.Image")));
            this.AboutUsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AboutUsButton.Location = new System.Drawing.Point(3, 504);
            this.AboutUsButton.Name = "AboutUsButton";
            this.AboutUsButton.Size = new System.Drawing.Size(242, 64);
            this.AboutUsButton.TabIndex = 9;
            this.AboutUsButton.Text = "Về Chúng Tôi";
            this.AboutUsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AboutUsButton.UseVisualStyleBackColor = true;
            this.AboutUsButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // ChangeRegulationButton
            // 
            this.ChangeRegulationButton.FlatAppearance.BorderSize = 0;
            this.ChangeRegulationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChangeRegulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeRegulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeRegulationButton.ForeColor = System.Drawing.Color.Black;
            this.ChangeRegulationButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangeRegulationButton.Image")));
            this.ChangeRegulationButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChangeRegulationButton.Location = new System.Drawing.Point(3, 364);
            this.ChangeRegulationButton.Name = "ChangeRegulationButton";
            this.ChangeRegulationButton.Size = new System.Drawing.Size(242, 64);
            this.ChangeRegulationButton.TabIndex = 7;
            this.ChangeRegulationButton.Text = "Thay Đổi Quy Định";
            this.ChangeRegulationButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChangeRegulationButton.UseVisualStyleBackColor = true;
            this.ChangeRegulationButton.Click += new System.EventHandler(this.ChangeRegulationButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.ForeColor = System.Drawing.Color.Black;
            this.ReportButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportButton.Image")));
            this.ReportButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReportButton.Location = new System.Drawing.Point(3, 294);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(242, 64);
            this.ReportButton.TabIndex = 6;
            this.ReportButton.Text = "Thống Kê";
            this.ReportButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // PayButton
            // 
            this.PayButton.FlatAppearance.BorderSize = 0;
            this.PayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.ForeColor = System.Drawing.Color.Black;
            this.PayButton.Image = ((System.Drawing.Image)(resources.GetObject("PayButton.Image")));
            this.PayButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PayButton.Location = new System.Drawing.Point(3, 155);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(242, 64);
            this.PayButton.TabIndex = 5;
            this.PayButton.Text = "Thanh Toán";
            this.PayButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // RoomButton
            // 
            this.RoomButton.FlatAppearance.BorderSize = 0;
            this.RoomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomButton.ForeColor = System.Drawing.Color.Black;
            this.RoomButton.Image = ((System.Drawing.Image)(resources.GetObject("RoomButton.Image")));
            this.RoomButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RoomButton.Location = new System.Drawing.Point(3, 85);
            this.RoomButton.Name = "RoomButton";
            this.RoomButton.Size = new System.Drawing.Size(245, 64);
            this.RoomButton.TabIndex = 4;
            this.RoomButton.Text = "Phòng";
            this.RoomButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RoomButton.UseVisualStyleBackColor = true;
            this.RoomButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(909, 69);
            this.panel4.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.button2.Image = global::QuanLyKhachSan.Properties.Resources.Loggin;
            this.button2.Location = new System.Drawing.Point(846, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 49);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(98)))));
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hotel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(739, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(98)))));
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 49);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(908, 641);
            this.Controls.Add(this.flpStatus);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void addname(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RoomButton;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button ChangeRegulationButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button AboutUsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button2;
        private FlowLayoutPanel flpRoom;
        private FlowLayoutPanel flpStatus;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Button button3;
        private Button button5;
    }
}

