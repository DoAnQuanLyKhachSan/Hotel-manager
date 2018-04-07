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
        public string _loaiPhong, _trangThai;


        public fSearch()
        {
            InitializeComponent();
            setDataStyleRoom();
            setDataRoomStatus();
            
        }
        #region method

        #region SetDataFromDataBase
        public string getCodeRoom()
        {
             return txbRoom.Text.ToString();
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
        #endregion

        #endregion

        #region events

        #region EventsSelectIndexFromComboBox
        public void cbxStyleRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStyleRoom.SelectedItem != null)
            {
                DataRowView drv = cbxStyleRoom.SelectedItem as DataRowView;
                _loaiPhong = cbxStyleRoom.SelectedValue.ToString();
            }
        }
        public void cbxRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoomStatus.SelectedItem != null)
            {
                DataRowView drv = cbxRoomStatus.SelectedItem as DataRowView;
                _trangThai = cbxRoomStatus.SelectedValue.ToString();
            }
        }
        #endregion

        #region EventsButton
        private void codeRoomSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvDataRoom.DataSource = SearchRoomDAO.Instance.ExecuteQuerySearchCodeRoom(getCodeRoom());
            }catch(Exception )
            {
                MessageBox.Show("Mã phòng không hợp lệ");
            }
        }
        private void styleRoomSearch_Click_1(object sender, EventArgs e)
        {
            dtgvDataRoom.DataSource = SearchRoomDAO.Instance.ExecuteQuerySearchStyleRoom(_loaiPhong);
        }
        private void statusRoomSearch_Click(object sender, EventArgs e)
        {
            dtgvDataRoom.DataSource = SearchRoomDAO.Instance.ExecuteQuerySearchStatusRoom(_trangThai);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion
    }
}
