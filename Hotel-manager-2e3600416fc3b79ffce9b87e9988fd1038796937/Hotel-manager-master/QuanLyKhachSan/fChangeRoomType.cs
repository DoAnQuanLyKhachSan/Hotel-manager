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
    public partial class fChangeRoomType : Form
    {
        public fChangeRoomType()
        {
            InitializeComponent();
            LoadListRoomType();
        }

        void LoadListRoomType()
        {
            dtgvListRoomType.DataSource = ChangeRegulationDAO.Instance.LoadListRoomType();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fUpdateRoomPrice _roomType = new fUpdateRoomPrice();
            _roomType.ShowDialog();
            LoadListRoomType();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fAddRoomType _roomType = new fAddRoomType();
            _roomType.ShowDialog();
            LoadListRoomType();
        }
    }
}
