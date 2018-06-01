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
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            loadStaff();
        }

        public  void loadStaff()
        {
            dtgvStaff.DataSource = StaffDAO.Instance.loadStaff();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fAddStaff f = new fAddStaff(this);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fDeleteStaff f = new fDeleteStaff(this);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fEditStaff f = new fEditStaff(this);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
