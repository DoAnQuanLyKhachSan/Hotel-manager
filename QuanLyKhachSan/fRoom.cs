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
        void LoadRoomList()
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong=p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai=p.TinhTrangPhong";


            dtgvPhong.DataSource = DataProvide.Instance.ExecuteQuery(query);
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
            fAddRoom _addRoom = new fAddRoom();
            _addRoom.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            fDeleteRoom _deleteRoom = new fDeleteRoom();
            _deleteRoom.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditRoom _editRoom = new fEditRoom();
            _editRoom.Show();

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            fRent _rentRoom = new fRent();
            _rentRoom.Show();
        }
    }
}
