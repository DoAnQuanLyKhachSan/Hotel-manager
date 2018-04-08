namespace QuanLyKhachSan
{
    partial class fReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnChartReport = new System.Windows.Forms.Panel();
            this.chReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTime = new System.Windows.Forms.Panel();
            this.btViewReport = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnTitles = new System.Windows.Forms.Panel();
            this.tbTitles = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnChartReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chReport)).BeginInit();
            this.pnTime.SuspendLayout();
            this.pnTitles.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnChartReport);
            this.panel1.Controls.Add(this.pnTime);
            this.panel1.Controls.Add(this.pnTitles);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 227);
            this.panel1.TabIndex = 0;
            // 
            // pnChartReport
            // 
            this.pnChartReport.Controls.Add(this.chReport);
            this.pnChartReport.Location = new System.Drawing.Point(396, 73);
            this.pnChartReport.Name = "pnChartReport";
            this.pnChartReport.Size = new System.Drawing.Size(358, 141);
            this.pnChartReport.TabIndex = 3;
            // 
            // chReport
            // 
            chartArea3.Name = "ChartArea1";
            this.chReport.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chReport.Legends.Add(legend3);
            this.chReport.Location = new System.Drawing.Point(16, 10);
            this.chReport.Name = "chReport";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Phòng loại A";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Phòng loại B";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Phòng loại C";
            this.chReport.Series.Add(series7);
            this.chReport.Series.Add(series8);
            this.chReport.Series.Add(series9);
            this.chReport.Size = new System.Drawing.Size(334, 117);
            this.chReport.TabIndex = 0;
            this.chReport.Text = "chart1";
            // 
            // pnTime
            // 
            this.pnTime.Controls.Add(this.btViewReport);
            this.pnTime.Controls.Add(this.dateTimePicker1);
            this.pnTime.Location = new System.Drawing.Point(15, 73);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(362, 82);
            this.pnTime.TabIndex = 2;
            // 
            // btViewReport
            // 
            this.btViewReport.Location = new System.Drawing.Point(241, 39);
            this.btViewReport.Name = "btViewReport";
            this.btViewReport.Size = new System.Drawing.Size(83, 33);
            this.btViewReport.TabIndex = 2;
            this.btViewReport.Text = "Xem Báo báo";
            this.btViewReport.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pnTitles
            // 
            this.pnTitles.Controls.Add(this.tbTitles);
            this.pnTitles.Location = new System.Drawing.Point(140, 3);
            this.pnTitles.Name = "pnTitles";
            this.pnTitles.Size = new System.Drawing.Size(420, 48);
            this.pnTitles.TabIndex = 0;
            // 
            // tbTitles
            // 
            this.tbTitles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbTitles.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTitles.Location = new System.Drawing.Point(38, 3);
            this.tbTitles.Name = "tbTitles";
            this.tbTitles.Size = new System.Drawing.Size(353, 44);
            this.tbTitles.TabIndex = 0;
            this.tbTitles.Text = "BÁO CÁO DOANH THU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 563);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(486, 501);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 53);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Trở Về";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "In Báo Cáo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(3, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(783, 256);
            this.panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 570);
            this.Controls.Add(this.panel2);
            this.Name = "fReport";
            this.Text = "fReport";
            this.panel1.ResumeLayout(false);
            this.pnChartReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chReport)).EndInit();
            this.pnTime.ResumeLayout(false);
            this.pnTitles.ResumeLayout(false);
            this.pnTitles.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnChartReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chReport;
        private System.Windows.Forms.Panel pnTime;
        private System.Windows.Forms.Button btViewReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnTitles;
        private System.Windows.Forms.TextBox tbTitles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}