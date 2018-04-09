using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
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
    public partial class fDeleteRoom : Form
    {
        RoomDTO _room = new RoomDTO();
        fRoom _froom = new fRoom();
        public fDeleteRoom(fRoom f)
        {
            InitializeComponent();
            _froom = f;
            LoadRoomList();
        }

        public void LoadRoomList()
        {
            dtgvPhong.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.ExecuteLoadInforRoomQuery());
        }

        private void dtgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _room.RoomCode = int.Parse(dtgvPhong.CurrentRow.Cells[0].Value.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data = DataProvide.Instance.ExecuteNonQuery(RoomDAO.Instance.deleteRoomDatabaseQuery() + _room.RoomCode);
                //return data(int) > 0 is success
                if (data > 0)
                {
                    MessageBox.Show("Xóa phòng thành công");
                    _froom.LoadRoomList();
                    LoadRoomList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa phòng thất bại ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
