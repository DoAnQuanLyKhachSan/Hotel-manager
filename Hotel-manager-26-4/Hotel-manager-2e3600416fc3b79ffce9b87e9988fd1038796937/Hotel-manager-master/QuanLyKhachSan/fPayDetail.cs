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
    public partial class fPayDetail : Form
    {
        public fPayDetail()
        {
            InitializeComponent();
            Load_fPayDetail();
        }

        public void Load_fPayDetail()
        {
            txbReadNameCus.Text = fPayInfo.getInfo.nameCus;
            txbReadAddress.Text = fPayInfo.getInfo.addressCus;

            dtgvPayDetail.DataSource = PayDAO.Instance.ListPayDetail(fPayInfo.getInfo.ListRentIDPay);

            txbTotalPrice.Text = PayDAO.Instance.GetTotalPrice();
        }

        private void btPrintPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất hóa đơn thanh toán thành công!");
            this.Close();
        }

        private void fPayDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            PayDAO.Instance.UpdateStatusPay(fPayInfo.getInfo.ListRentIDPay);

            fPayInfo.getInfo.ListRentIDPay = new List<string>();
        }
    }
}
