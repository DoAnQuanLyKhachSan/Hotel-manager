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
            string query = "select PHONG.MaPhong from PHONG";
            string[] data = DataProvide.Instance.ExecuteReader(query).Split(' ');
            this.textBox1.AutoCompleteCustomSource.AddRange(data);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

