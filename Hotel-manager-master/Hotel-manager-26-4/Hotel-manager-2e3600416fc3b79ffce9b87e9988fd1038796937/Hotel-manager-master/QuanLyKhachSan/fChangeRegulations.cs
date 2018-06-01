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
    public partial class fChangeRegulations : Form
    {
        public fChangeRegulations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fChangeRoomType _roomType = new fChangeRoomType();
            this.Hide();
            _roomType.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fChangeNumOfCus _roomType = new fChangeNumOfCus();
            this.Hide();
            _roomType.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fChangeMaxCus _roomType = new fChangeMaxCus();
            this.Hide();
            _roomType.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fChangeRate f = new fChangeRate();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
