using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
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
    public partial class fAddRoom : Form
    {
        RoomDTO _room = new RoomDTO();
        public fAddRoom()
        {
            InitializeComponent();
        
            setDataStyleRoom();
        
        }

        #region set
        private void setDataStyleRoom() 
        {
            cbxStyleRoom.DisplayMember = "TenLoaiPhong";
            cbxStyleRoom.ValueMember = "MaLoaiPhong";
            cbxStyleRoom.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataStyleRoomQuery());
        }

        private void setDataPriceRoom(string _codeStyleRoom) 
        {
            string query = "select DonGia from dbo.LOAI_PHONG where MaLoaiPhong = " + _codeStyleRoom;
            txbPrice.Text = DataProvide.Instance.ExecuteReader(query);
        }

        #endregion

        #region get
        private RoomDTO getCodeRoom()
        {
            _room.RoomCode = int.Parse(txbRoomCode.Text.ToString());
            return _room;
        }
        private RoomDTO getNameRoom()
        {
            _room.RoomName = txbRoomName.Text.ToString();
            return _room;
        }
        private void cbxStyleRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStyleRoom.SelectedItem != null)
            {
                DataRowView drv = cbxStyleRoom.SelectedItem as DataRowView;
                _room.RoomStyle = int.Parse(cbxStyleRoom.SelectedValue.ToString());
                setDataPriceRoom(cbxStyleRoom.SelectedValue.ToString());
            }
        }
        private RoomDTO getPriceRoom()
        {
            
            return _room;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

    
    
    }
}
