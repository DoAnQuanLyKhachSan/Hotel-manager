using Microsoft.SqlServer.Server;
using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fRoom : Form
    {
        public fRoom()
        {
            InitializeComponent();
            LoadRoomList();
            
        }
        
        private void fRoom_Load(object sender, EventArgs e)
        {

        }
        public void LoadRoomList()
        {
            
            dtgvPhong.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.ExecuteLoadInforRoomQuery());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fSearch _searchRoom = new fSearch();
            _searchRoom.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddRoom _addRoom = new fAddRoom(this);
          
            _addRoom.Show();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            fDeleteRoom _deleteRoom = new fDeleteRoom(this);
            this.Hide();
            _deleteRoom.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditRoom _editRoom = new fEditRoom(this);
            this.Hide();
            _editRoom.ShowDialog();
            this.Show();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            fRent _rentRoom = new fRent();
            _rentRoom.Show();
        }
        
    }
}
