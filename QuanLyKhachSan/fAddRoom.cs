using QuanLyKhachSan.DAO;
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
    public partial class fAddRoom : Form
    {
        string _styleRoom;
        string _price;
        public fAddRoom()
        {
            InitializeComponent();
        
            setDataStyleRoom();
        }
        private void setDataStyleRoom() 
        {
            string setDataStyleRoomQuery = "select MaLoaiPhong,TenLoaiPhong From dbo.LOAI_PHONG";
            cbxStyleRoom.DisplayMember = "TenLoaiPhong";
            cbxStyleRoom.ValueMember = "MaLoaiPhong";
            cbxStyleRoom.DataSource = DataProvide.Instance.ExecuteQuery(setDataStyleRoomQuery);
        }
        
        private void cbxStyleRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStyleRoom.SelectedItem != null)
            {
                DataRowView drv = cbxStyleRoom.SelectedItem as DataRowView;
                _styleRoom = cbxStyleRoom.SelectedValue.ToString();
            }
        }
       
        //private void setDataPriceRoom()
        //{
        //    if()
        //}

        private string getCodeRoom()
        {
            return txbRoomCode.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
