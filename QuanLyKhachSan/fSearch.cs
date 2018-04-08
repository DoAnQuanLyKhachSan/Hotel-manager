using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fSearch : Form
    {
        RoomDTO _room = new RoomDTO();
        public fSearch()
        {
            InitializeComponent();
          
            setDataStyleRoom();
            setDataRoomStatus();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region set
        private void setDataStyleRoom() //value combo box theo ma loai phong
        {
            cbxStyleRoom.DisplayMember = "TenLoaiPhong";
            cbxStyleRoom.ValueMember = "MaLoaiPhong";
            cbxStyleRoom.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataStyleRoomQuery());
        }

        private void setDataRoomStatus()//value combo box theo ma loai phong
        {
            cbxRoomStatus.DisplayMember = "TenTrangThai";
            cbxRoomStatus.ValueMember = "MaTrangThai";
            cbxRoomStatus.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataRoomStatusQuery());
        }
        #endregion

        #region get
        private RoomDTO getCodeRoom()
        {
            _room.RoomCode = int.Parse(txbRoom.Text.ToString());
            return _room;
        }
        private void cbxStyleRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStyleRoom.SelectedItem != null)
            {
                DataRowView drv = cbxStyleRoom.SelectedItem as DataRowView;
                _room.RoomStyle = int.Parse(cbxStyleRoom.SelectedValue.ToString());
            }
        }
        private void cbxRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoomStatus.SelectedItem != null)
            {
                DataRowView drv = cbxRoomStatus.SelectedItem as DataRowView;
                _room.RoomStatus = int.Parse(cbxRoomStatus.SelectedValue.ToString());
            }
        }
        #endregion

        #region event
        private void codeRoomSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.MaPhong = " + getCodeRoom().RoomCode.ToString();
                dtgvDataRoom.DataSource = DataProvide.Instance.ExecuteQuery(query);
            }catch(Exception )
            {
                MessageBox.Show("Mã phòng không hợp lệ");
            }
        }

        private void styleRoomSearch_Click_1(object sender, EventArgs e)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.MaLoaiPhong = " + _room.RoomStyle;
                dtgvDataRoom.DataSource = DataProvide.Instance.ExecuteQuery(query);
        }

        private void statusRoomSearch_Click(object sender, EventArgs e)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.TinhTrangPhong = " + _room.RoomStatus;
            dtgvDataRoom.DataSource = DataProvide.Instance.ExecuteQuery(query);
        }
        #endregion



    }
}
