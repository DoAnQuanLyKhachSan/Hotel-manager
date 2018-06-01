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
       // MainMenu m = new MainMenu();
        fLogin fLoginCurrent = new fLogin();
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
        public fRoom(fLogin login)
        {
            InitializeComponent();
            LoadRoomList();
            //m = main;
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
                this.Hide();
                _searchRoom.ShowDialog();
                this.Show();
            } else MessageBox.Show("Bạn không có quyền truy cập");
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fAddRoom") == true)
            {
                
                fAddRoom _addRoom = new fAddRoom(this/*, m*/);
                this.Hide();
                _addRoom.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fEditRoom") == true)
            {
                fEditRoom _editRoom = new fEditRoom(this/*, m*/);
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
                this.Hide();

                _rentRoom.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fDeleteRoom") == true)
            {
                fDeleteRoom f = new fDeleteRoom(this);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
        }
    }
}
