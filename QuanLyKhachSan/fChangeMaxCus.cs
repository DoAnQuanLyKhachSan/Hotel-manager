using QuanLyKhachSan;
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
    public partial class fChangeMaxCus : Form
    {
        public fChangeMaxCus()
        {
            InitializeComponent();
            LoadMaxCus();
        }

        public void LoadMaxCus()
        {
            txbMasCusOld.Text = ChangeRegulationDAO.Instance.getMaxCus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ChangeRegulationDAO.Instance.IsNumber(txbMasCusNew.Text)==false)
            {
                MessageBox.Show("Giá trị nhập vào phải là Số nguyên!","Chú ý!");
                return;
            }

            if (txbMasCusNew.Text.Length==0)
            {
                MessageBox.Show("Không được để trống trường này!", "Chú ý!");
                return;
            }

            int max = int.Parse(txbMasCusNew.Text);

            ChangeRegulationDAO.Instance.UpdateMaxCus(max);
            LoadMaxCus();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
