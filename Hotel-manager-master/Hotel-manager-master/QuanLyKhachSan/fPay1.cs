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
    public partial class fPay1 : Form
    {
        public fPay1()
        {
            InitializeComponent();
            LoadPayInfo();
        }

        public void LoadPayInfo()
        {
            txbReadNameCus.Text = fPayView1.getInfo.nameCus;
            txbReadAddress.Text = fPayView1.getInfo.addressCus;

            dtgvPayInfo.DataSource = PayDAO.Instance.LoadPayInfo(fPayView1.getInfo.nameCus, fPayView1.getInfo.addressCus);

            txbSumPrice.Text = PayDAO.Instance.getTotalPrice(fPayView1.getInfo.nameCus, fPayView1.getInfo.addressCus).ToString() + "đ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
