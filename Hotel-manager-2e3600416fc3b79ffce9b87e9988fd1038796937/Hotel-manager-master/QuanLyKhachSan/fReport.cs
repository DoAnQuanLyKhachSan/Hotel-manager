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

        private void fReport_Activated(object sender, EventArgs e)
        {
           
        }

        private void btViewReport_Click(object sender, EventArgs e)
        {
            int _month = dtp.Value.Month, _year = dtp.Value.Year;

            dtgvReport.DataSource = ReportDAO.Instance.ViewReport(_month,_year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCreateReport_Click(object sender, EventArgs e)
        {
            try
            {
                int _month = dtp.Value.Month, _year = dtp.Value.Year;
                ReportDAO.Instance.CreateReport(_month, _year);
            }
            catch
            {
                MessageBox.Show("Báo cáo tháng này đã tạo rồi, Nhấn xem báo cáo!");
            }
        }
    }
}
