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
    public partial class fPay : Form
    {
        public fPay()
        {
            InitializeComponent();
            LoadPayInfo();
        }

        public void LoadPayInfo()
        {
            txbReadNameCus.Text = fPayView.getInfo.nameCus;
            txbReadAddress.Text = fPayView.getInfo.addressCus;

            dtgvPayInfo.DataSource = PayDAO.Instance.LoadPayInfo(fPayView.getInfo.nameCus, fPayView.getInfo.addressCus);

            txbSumPrice.Text = PayDAO.Instance.getTotalPrice(fPayView.getInfo.nameCus, fPayView.getInfo.addressCus).ToString() + "đ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
