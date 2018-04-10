using QuanLyKhachSan;
using System;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
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
    public partial class MainMenu : Form
    {
        private object resources;

        public MainMenu()
        {
            InitializeComponent();
            LoadRoom();
            LoadStatusOfRooms();
            LoadListRoom();
        }
        #region Method
        public void LoadRoom()
        {
            List<RoomDTO> RoomList = RoomDAO.Instance.LoadRoomList();
            foreach (RoomDTO roomDTO in RoomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeigh };
                btn.Text = roomDTO.RoomName;
                switch (roomDTO.RoomStyle)
                {
                    case 1:
                        btn.Image = global::QuanLyKhachSan.Properties.Resources.room1;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        break;
                    case 2:
                        btn.Image = global::QuanLyKhachSan.Properties.Resources.room2;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        break;
                    case 3:
                        btn.Image = global::QuanLyKhachSan.Properties.Resources.room3;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        break;
                    default:
                        break;
                }
                switch (roomDTO.RoomStatus)
                {
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                    case 2:
                        btn.BackColor = Color.Red;
                        break;
                    case 3:
                        btn.BackColor = Color.HotPink;
                        break;
                    default:
                        break;
                }
                flpRoom.Controls.Add(btn);
            }
        }
        public void LoadStatusOfRooms()
        {
            int Total = 0, available = 0, inused = 0, undermaintainance = 0;
            List<RoomDTO> StatusRoomList = RoomDAO.Instance.LoadRoomList();
            foreach (RoomDTO roomDTO in StatusRoomList)
            {               
                //btn.Text = roomDTO.RoomName;               
                switch (roomDTO.RoomStatus)
                {
                    case 1:
                        available += 1;
                        break;
                    case 2:
                        inused += 1;
                        break;
                    case 3:
                        undermaintainance += 1;
                        break;
                    default:
                        break;
                }
                
            }
            Total = available + inused + undermaintainance;
            //All
            Button btnAll = new Button() { Width = 100, Height = 25 };
            btnAll.Text = "Tất Cả " + Total.ToString();
            btnAll.BackColor = Color.White;
            //Available
            Button btnAv = new Button() { Width = 100, Height = 25 };
            btnAv.Text = "Có Thể Thuê " + available.ToString();
            btnAv.BackColor = Color.SeaGreen;
            //Inused
            Button btnIU = new Button() { Width = 100, Height = 25 };
            btnIU.Text = "Đã Thuê " + inused.ToString();
            btnIU.BackColor = Color.PaleVioletRed;
            //Undermaintainance
            Button btnMT = new Button() { Width = 100, Height = 25 };
            btnMT.Text = "Đang Sửa Chữa " + undermaintainance.ToString();
            btnMT.BackColor = Color.Yellow;
            flpStatus.Controls.Add(btnAll);
            flpStatus.Controls.Add(btnAv);
            flpStatus.Controls.Add(btnIU);
            flpStatus.Controls.Add(btnMT);
        }
        public void LoadListRoom()
        {
            string query = "select PHONG.MaPhong from PHONG";
            string[] data = DataProvide.Instance.ExecuteReader(query).Split(' ');
            this.textBox1.AutoCompleteCustomSource.AddRange(data);
        }
        #endregion
        #region Events

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRoom _room = new fRoom();
            _room.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPay _room = new fPay();
            _room.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReport _room = new fReport();
            _room.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApp5.Form1 _room = new WindowsFormsApp5.Form1();
            _room.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        

        private void flpRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin _room = new fLogin();
            _room.ShowDialog();
            this.Show();
        }
        #endregion
    }
}

