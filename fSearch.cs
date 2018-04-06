using QuanLyKhachSan.DAO;
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
        string _loaiPhong, _trangThai;
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

        private void setDataStyleRoom() //value combo box theo ma loai phong
        {
            string setDataStyleRoomQuery = "select MaLoaiPhong,TenLoaiPhong From dbo.LOAI_PHONG";
            cbxStyleRoom.DisplayMember = "TenLoaiPhong";
            cbxStyleRoom.ValueMember = "MaLoaiPhong";
            cbxStyleRoom.DataSource = DataProvide.Instance.ExecuteQuery(setDataStyleRoomQuery);
        }

        private void setDataRoomStatus()//value combo box theo ma loai phong
        {
            string setDataRoomStatusQuery = "select TenTrangThai,TinhTrangPhong from dbo.TRANG_THAI_PHONG";
            cbxRoomStatus.DisplayMember = "TenTrangThai";
            cbxRoomStatus.ValueMember = "TinhTrangPhong";
            cbxRoomStatus.DataSource = DataProvide.Instance.ExecuteQuery(setDataRoomStatusQuery);
        }

        private string getCodeRoom()
        {
            return txbRoom.Text.ToString();
        }
        private void cbxStyleRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStyleRoom.SelectedItem != null)
            {
                DataRowView drv = cbxStyleRoom.SelectedItem as DataRowView;
                _loaiPhong = cbxStyleRoom.SelectedValue.ToString();
            }
        }
        private void cbxRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoomStatus.SelectedItem != null)
            {
                DataRowView drv = cbxRoomStatus.SelectedItem as DataRowView;
                _trangThai = cbxRoomStatus.SelectedValue.ToString();
            }
        }

       
        
        private void codeRoomSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.TinhTrangPhong = p.TinhTrangPhong where p.MaPhong = " + getCodeRoom();
                dtgvDataRoom.DataSource = DataProvide.Instance.ExecuteQuery(query);
            }catch(Exception )
            {
                MessageBox.Show("Mã phòng không hợp lệ");
            }
        }

        private void styleRoomSearch_Click_1(object sender, EventArgs e)
        {
                string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.TinhTrangPhong = p.TinhTrangPhong where p.MaLoaiPhong = " + _loaiPhong;
                dtgvDataRoom.DataSource = DataProvide.Instance.ExecuteQuery(query);
        }

        private void statusRoomSearch_Click(object sender, EventArgs e)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.TinhTrangPhong = p.TinhTrangPhong where p.TinhTrangPhong = " + _trangThai;
            dtgvDataRoom.DataSource = DataProvide.Instance.ExecuteQuery(query);
        }
    



    }
}
