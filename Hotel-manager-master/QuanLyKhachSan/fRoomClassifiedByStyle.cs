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
    public partial class fRoomClassifiedByStyle : Form
    {
        List<Button> buttonlist = new List<Button>();
        public fRoomClassifiedByStyle(int RoomStyle)
        {
            InitializeComponent();
        }
        public void LoadRoom()
        {
            List<RoomDTO> RoomList = RoomDAO.Instance.LoadRoomList();
            foreach (RoomDTO roomDTO in RoomList)
            {

                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeigh };
                btn.Text = roomDTO.RoomName;
                btn.Click += new EventHandler(btn_Click);
                btn.Tag = roomDTO;
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
                        btn.BackColor = Color.LightPink;
                        break;
                    case 2:
                        btn.BackColor = Color.LightGray;
                        break;
                    case 3:
                        btn.BackColor = Color.OrangeRed;
                        break;
                    default:
                        break;
                }
                buttonlist.Add(btn);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
