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
        Bitmap bmp;
        private void btPrintPay_Click(object sender, EventArgs e)
        {

            int height = dtgvPayDetail.Height;
            dtgvPayDetail.Height = dtgvPayDetail.RowCount * dtgvPayDetail.RowTemplate.Height * 2;
            bmp = new Bitmap(dtgvPayDetail.Width, dtgvPayDetail.Height);
            dtgvPayDetail.DrawToBitmap(bmp, new Rectangle(0, 0, dtgvPayDetail.Width, dtgvPayDetail.Height));
            printDocument1.Print();

            MessageBox.Show("Xuất hóa đơn thanh toán thành công!");
            this.Close();
        }

        private void fPayDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            PayDAO.Instance.UpdateStatusPay(fPayInfo.getInfo.ListRentIDPay);

            fPayInfo.getInfo.ListRentIDPay = new List<string>();
        }

    

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string text = "KHÁCH SẠN UIT\nTên khách hàng : " + txbReadNameCus.Text + "\nĐịa chỉ : " + txbReadAddress.Text + "\nTổng tiền thanh toán :" + txbTotalPrice.Text+" Đồng";
             e.Graphics.DrawString(text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
             e.Graphics.DrawImage(bmp, 0, 200);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
