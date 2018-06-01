using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void btCreateReport_Click(object sender, EventArgs e)
        {
            try
            {
                int _month = dtp.Value.Month, _year = dtp.Value.Year;
                ReportDAO.Instance.CreateReport(_month, _year);
                MessageBox.Show("Tạo báo cáo thành công!");
            }
            catch
            {
                MessageBox.Show("Báo cáo tháng này đã tạo rồi, Nhấn xem báo cáo!");
            }
        }

        private void btViewReport_Click(object sender, EventArgs e)
        {
            int _month = dtp.Value.Month, _year = dtp.Value.Year;

            dtgvReport.DataSource = ReportDAO.Instance.ViewReport(_month, _year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
