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
        private fRoom _fRoom;
        RoomDTO _room = new RoomDTO();
        //MainMenu m = new MainMenu();
        public fAddRoom(fRoom form)
        {
            InitializeComponent();
            _fRoom = form;
            txbRoomCode.Select(); // focus cusor in textbox : CodeName
            setDataStyleRoom();
        }
        public fAddRoom(fRoom form, MainMenu main)
        {
            InitializeComponent();
            _fRoom = form;
           // m = main;
            txbRoomCode.Select(); // focus cusor in textbox : CodeName
            setDataStyleRoom();
        }
        #region set
        private void setDataStyleRoom() 
        {
            cbxStyleRoom.DisplayMember = "TenLoaiPhong";
            cbxStyleRoom.ValueMember = "MaLoaiPhong";
            cbxStyleRoom.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataStyleRoomQuery());
        }

      
        private void cbxStyleRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStyleRoom.SelectedItem != null)
            {
                DataRowView drv = cbxStyleRoom.SelectedItem as DataRowView;
                _room.RoomStyle = int.Parse(cbxStyleRoom.SelectedValue.ToString());
                string query = RoomDAO.Instance.cbxstyleRoom_SelectIndexQuery() + _room.RoomStyle;
                txbPrice.Text = DataProvide.Instance.ExecuteReader(query); // hien thi don gia theo StyleRoom
            }
        }
        #endregion

        #region get
        private RoomDTO getCodeRoom()
        {
            _room.RoomCode = int.Parse(txbRoomCode.Text.ToString());
            return _room;
        }
        private int getCodeRoomint()
        {
            int roomcode;
            if (Int32.TryParse(txbRoomCode.Text.ToString(), out roomcode))
            {
                _room.RoomCode = roomcode;
            }
            return _room.RoomCode;
        }
        private RoomDTO getNameRoom()
        {
            _room.RoomName = txbRoomName.Text.ToString();
            return _room;
        }
       
        private RoomDTO getNoteRoom()
        {
            _room.RoomNote = txbNote.Text.ToString();
            return _room;
        }
        #endregion


        private void button1_Click(object sender, EventArgs e) // button add
        {

            try
            {
               int data = DataProvide.Instance.ExecuteNonQuery(RoomDAO.Instance.addRoomDatabaseQuery(), new object[] { getCodeRoom().RoomCode, getNameRoom().RoomName, _room.RoomStyle, getNoteRoom().RoomNote });
                if (data < 0)
                {
                    MessageBox.Show("Thêm phòng thành công");
                    _fRoom.LoadRoomList();
                    Button button = addbutton();
                    //m.AddRoom(button);
                   // m.ReLoadStatusOfRooms();
                }
            }
            catch(Exception ex)
            {
                if(ex is SqlException)
                {
                    MessageBox.Show("Mã phòng đã tồn tại");
                }else
                {
                    MessageBox.Show("Nhập mã phòng sai");
                }
            }
        }
        private Button addbutton()
        {
            Button button = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeigh };
            button.Text = getNameRoom().RoomName;
            switch (getCodeRoom().RoomStyle)
            {
                case 1:
                    button.Image = global::QuanLyKhachSan.Properties.Resources.room1;
                    break;
                case 2:
                    button.Image = global::QuanLyKhachSan.Properties.Resources.room2;
                    break;
                case 3:
                    button.Image = global::QuanLyKhachSan.Properties.Resources.room3;
                    break;
                default:
                    break;
            }
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.TextAlign = ContentAlignment.BottomCenter;
            button.BackColor = Color.LightPink;
            button.Click += new EventHandler(button_Click);
            return button;
        }
        private void button_Click(object sender, EventArgs e)
        {
            int RoomCode = getCodeRoomint();
            this.Hide();
           
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
