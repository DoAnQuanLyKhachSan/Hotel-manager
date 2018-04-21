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
<<<<<<< HEAD:Hotel-manager-master_17-4v4/Hotel-manager-master_16-4 - Copy/Hotel-manager-master/Hotel-manager-master/Hotel-manager-master/QuanLyKhachSan/fRoom.cs
        MainMenu m = new MainMenu(1);
=======
        MainMenu m = new MainMenu();
        fLogin fLoginCurrent = new fLogin();
>>>>>>> 79bd8ce4d26160fc385df522e155bfc60d43b97e:Hotel-manager-master/QuanLyKhachSan/fRoom.cs
        public fRoom()
        {
            InitializeComponent();
            LoadRoomList();            
        }
        private int getGroupCode()
        {
            string query = "select MaNhom from NGUOI_DUNG where TenDangNhap = N'" + fLoginCurrent.getUser().UserName + "'";
            return int.Parse(DataProvide.Instance.ExecuteReader(query));
        }
        public fRoom(MainMenu main,fLogin login)
        {
            InitializeComponent();
            LoadRoomList();
            m = main;
            fLoginCurrent = login;
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
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fSearch") == true)
            {
                fSearch _searchRoom = new fSearch();
                _searchRoom.Show();
            } else MessageBox.Show("Bạn không có quyền truy cập");
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fAddRoom") == true)
            {
                fAddRoom _addRoom = new fAddRoom(this, m);

                _addRoom.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
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
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fEditRoom") == true)
            {
                fEditRoom _editRoom = new fEditRoom(this, m);
                this.Hide();
                _editRoom.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fRent") == true)
            {
                fRent _rentRoom = new fRent(this);
                _rentRoom.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
        }
        
    }
}
