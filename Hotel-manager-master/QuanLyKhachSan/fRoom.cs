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
        MainMenu m = new MainMenu();
        public fRoom()
        {
            InitializeComponent();
            LoadRoomList();            
        }
        public fRoom(MainMenu main)
        {
            InitializeComponent();
            LoadRoomList();
            m = main;
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
            fAddRoom _addRoom = new fAddRoom(this,m);
          
            _addRoom.Show();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            fDeleteRoom _deleteRoom = new fDeleteRoom(this,m);
            this.Hide();
            _deleteRoom.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditRoom _editRoom = new fEditRoom(this,m);
            this.Hide();
            _editRoom.ShowDialog();
            this.Show();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            fRent _rentRoom = new fRent(this);
            _rentRoom.Show();
        }
        
    }
}
