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
    public partial class fPayView : Form
    {
        public fPayView()
        {
            InitializeComponent();
        }

        public class getInfo
        {
            static public string nameCus;
            static public string addressCus;
        }

        private void txbCusName_TextChanged(object sender, EventArgs e)
        {
            List<string> listAddr = PayDAO.Instance.getAddressCus(txbCusName.Text.ToString());

            if (listAddr != null)
                cbAddress.DataSource = listAddr;
        }

        private void btPayView_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbCusName.Text.Length == 0)
                {
                    MessageBox.Show("Tên khách hàng không được để trống"); return;
                }
                getInfo.nameCus = txbCusName.Text;
                getInfo.addressCus = cbAddress.SelectedValue.ToString();
                fPay f = new fPay();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            catch
            {
                MessageBox.Show("Tên khách hàng không có trong dữ liệu thuê phòng");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
