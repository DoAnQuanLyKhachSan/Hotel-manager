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
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flpRoom
            // 
            resources.ApplyResources(this.flpRoom, "flpRoom");
            this.flpRoom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.flpRoom_Paint);
            // 
            // flpStatus
            // 
            this.flpStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.flpStatus, "flpStatus");
            this.flpStatus.Name = "flpStatus";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(167)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.AboutUsButton);
            this.panel2.Controls.Add(this.ChangeRegulationButton);
            this.panel2.Controls.Add(this.ReportButton);
            this.panel2.Controls.Add(this.PayButton);
            this.panel2.Controls.Add(this.RoomButton);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // AboutUsButton
            // 
            this.AboutUsButton.FlatAppearance.BorderSize = 0;
            this.AboutUsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.AboutUsButton, "AboutUsButton");
            this.AboutUsButton.ForeColor = System.Drawing.Color.Black;
            this.AboutUsButton.Name = "AboutUsButton";
            this.AboutUsButton.UseVisualStyleBackColor = true;
            this.AboutUsButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // ChangeRegulationButton
            // 
            this.ChangeRegulationButton.FlatAppearance.BorderSize = 0;
            this.ChangeRegulationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.ChangeRegulationButton, "ChangeRegulationButton");
            this.ChangeRegulationButton.ForeColor = System.Drawing.Color.Black;
            this.ChangeRegulationButton.Name = "ChangeRegulationButton";
            this.ChangeRegulationButton.UseVisualStyleBackColor = true;
            this.ChangeRegulationButton.Click += new System.EventHandler(this.ChangeRegulationButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.ReportButton, "ReportButton");
            this.ReportButton.ForeColor = System.Drawing.Color.Black;
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // PayButton
            // 
            this.PayButton.FlatAppearance.BorderSize = 0;
            this.PayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.PayButton, "PayButton");
            this.PayButton.ForeColor = System.Drawing.Color.Black;
            this.PayButton.Name = "PayButton";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // RoomButton
            // 
            this.RoomButton.FlatAppearance.BorderSize = 0;
            this.RoomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.RoomButton, "RoomButton");
            this.RoomButton.ForeColor = System.Drawing.Color.Black;
            this.RoomButton.Name = "RoomButton";
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
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.button2.Image = global::QuanLyKhachSan.Properties.Resources.Loggin;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Name = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.search;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.flpStatus);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
    }
}

