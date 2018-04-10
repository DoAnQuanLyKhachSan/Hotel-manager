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
    public partial class fEditRoom : Form
    {
        RoomDTO _room = new RoomDTO();
        fRoom _fRoom = new fRoom();
        public fEditRoom(fRoom f)
        {

            InitializeComponent();
            _fRoom = f;
            setDataStatusRoomNew();
            setDataStyleRoomNew();
            loadRoomList();
        }

        void loadRoomList()
        {
            dtgvPhong.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.ExecuteLoadInforRoomQuery());
        }
        private void setDataStyleRoomNew()
        {
            cbxRoomStyleNew.DisplayMember = "TenLoaiPhong";
            cbxRoomStyleNew.ValueMember = "MaLoaiPhong";
            cbxRoomStyleNew.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataStyleRoomQuery());
        }

        private void setDataStatusRoomNew()
        {
            cbxRoomStatusNew.DisplayMember = "TenTrangThai";
            cbxRoomStatusNew.ValueMember = "MaTrangThai";
            cbxRoomStatusNew.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataRoomStatusQuery());
        }

        private int getRoomCodeOld()
        {
           return int.Parse(txbRoomCodeOld.Text.ToString());
            
        }
        private RoomDTO getCodeRoomNew()
        {
            _room.RoomCode = int.Parse(txtRoomCodeNew.Text.ToString());
            return _room;
        }
        private RoomDTO getNameRoomNew()
        {
            _room.RoomName = txbRoomNameNew.Text.ToString();
            return _room;
        }

        private RoomDTO getNoteRoomNew()
        {
            _room.RoomNote = txbRoomNoteNew.Text.ToString();
            return _room;
        }

       

        private void cbxRoomStyleNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoomStyleNew.SelectedItem != null)
            {
                DataRowView drv = cbxRoomStyleNew.SelectedItem as DataRowView;
                _room.RoomStyle = int.Parse(cbxRoomStyleNew.SelectedValue.ToString());
            }
        }

        private void cbxRoomStatusNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoomStatusNew.SelectedItem != null)
            {
                DataRowView drv = cbxRoomStatusNew.SelectedItem as DataRowView;
                _room.RoomStatus = int.Parse(cbxRoomStatusNew.SelectedValue.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //return data ( int ) < 0 is success 
                int data = DataProvide.Instance.ExecuteNonQuery(RoomDAO.Instance.UpdateRoomDatabaseQuery(), new object[] { getCodeRoomNew().RoomCode, getNameRoomNew().RoomName, _room.RoomStyle, getNoteRoomNew().RoomNote ,_room.RoomStatus,getRoomCodeOld()});
                if (data > 0)
                {
                    MessageBox.Show("Thêm phòng thành công");
                    _fRoom.LoadRoomList();
                    loadRoomList(); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập thông tin cần sửa");
            }
        }
    }
}
