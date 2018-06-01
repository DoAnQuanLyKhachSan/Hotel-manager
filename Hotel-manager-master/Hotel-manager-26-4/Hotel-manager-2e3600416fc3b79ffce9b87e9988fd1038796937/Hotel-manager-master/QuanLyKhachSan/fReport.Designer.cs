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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnChartReport = new System.Windows.Forms.Panel();
            this.chReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTime = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btCreateReport = new System.Windows.Forms.Button();
            this.btViewReport = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvReport = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnChartReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chReport)).BeginInit();
            this.pnTime.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnChartReport);
            this.panel1.Controls.Add(this.pnTime);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 227);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(221, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo cáo doanh thu";
            // 
            // pnChartReport
            // 
            this.pnChartReport.Controls.Add(this.chReport);
            this.pnChartReport.Location = new System.Drawing.Point(396, 73);
            this.pnChartReport.Name = "pnChartReport";
            this.pnChartReport.Size = new System.Drawing.Size(370, 141);
            this.pnChartReport.TabIndex = 3;
            // 
            // chReport
            // 
            chartArea1.Name = "ChartArea1";
            this.chReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chReport.Legends.Add(legend1);
            this.chReport.Location = new System.Drawing.Point(16, 10);
            this.chReport.Name = "chReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Phòng loại A";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Phòng loại B";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Phòng loại C";
            this.chReport.Series.Add(series1);
            this.chReport.Series.Add(series2);
            this.chReport.Series.Add(series3);
            this.chReport.Size = new System.Drawing.Size(329, 117);
            this.chReport.TabIndex = 0;
            this.chReport.Text = "chart1";
            // 
            // pnTime
            // 
            this.pnTime.Controls.Add(this.label2);
            this.pnTime.Controls.Add(this.btCreateReport);
            this.pnTime.Controls.Add(this.btViewReport);
            this.pnTime.Controls.Add(this.dtp);
            this.pnTime.Location = new System.Drawing.Point(15, 59);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(366, 155);
            this.pnTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn thời gian để xem báo cáo : ";
            // 
            // btCreateReport
            // 
            this.btCreateReport.FlatAppearance.BorderSize = 0;
            this.btCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCreateReport.Image = ((System.Drawing.Image)(resources.GetObject("btCreateReport.Image")));
            this.btCreateReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCreateReport.Location = new System.Drawing.Point(14, 65);
            this.btCreateReport.Name = "btCreateReport";
            this.btCreateReport.Size = new System.Drawing.Size(144, 87);
            this.btCreateReport.TabIndex = 3;
            this.btCreateReport.Text = "Tạo báo cáo";
            this.btCreateReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCreateReport.UseVisualStyleBackColor = true;
            this.btCreateReport.Click += new System.EventHandler(this.btCreateReport_Click);
            // 
            // btViewReport
            // 
            this.btViewReport.FlatAppearance.BorderSize = 0;
            this.btViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btViewReport.Image = ((System.Drawing.Image)(resources.GetObject("btViewReport.Image")));
            this.btViewReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btViewReport.Location = new System.Drawing.Point(202, 65);
            this.btViewReport.Name = "btViewReport";
            this.btViewReport.Size = new System.Drawing.Size(144, 87);
            this.btViewReport.TabIndex = 2;
            this.btViewReport.Text = "Xem báo cáo";
            this.btViewReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btViewReport.UseVisualStyleBackColor = true;
            this.btViewReport.Click += new System.EventHandler(this.btViewReport_Click);
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(14, 39);
            this.dtp.MaximumSize = new System.Drawing.Size(400, 50);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(312, 20);
            this.dtp.TabIndex = 1;
            this.dtp.Value = new System.DateTime(2018, 4, 14, 1, 19, 7, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 591);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(565, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 87);
            this.button2.TabIndex = 4;
            this.button2.Text = "Trở Về";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(81, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 87);
            this.button1.TabIndex = 3;
            this.button1.Text = "In Báo Cáo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvReport);
            this.panel4.Location = new System.Drawing.Point(3, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(783, 256);
            this.panel4.TabIndex = 2;
            // 
            // dtgvReport
            // 
            this.dtgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dtgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport.Location = new System.Drawing.Point(15, 3);
            this.dtgvReport.Name = "dtgvReport";
            this.dtgvReport.Size = new System.Drawing.Size(751, 245);
            this.dtgvReport.TabIndex = 0;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(798, 596);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnChartReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chReport)).EndInit();
            this.pnTime.ResumeLayout(false);
            this.pnTime.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnChartReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chReport;
        private System.Windows.Forms.Panel pnTime;
        private System.Windows.Forms.Button btCreateReport;
        private System.Windows.Forms.Button btViewReport;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}