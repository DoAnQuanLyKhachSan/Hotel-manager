using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
namespace QuanLyKhachSan
{
    public partial class fViewRoom : Form
    {
        MainMenu mainMenu = new MainMenu();
        int RoomCode;
        public fViewRoom(List<BillInfoDTO> ListBillInfo, RoomDTO roominfo, int roomcode, MainMenu mainmenu,int paystatus=2)
        {
            InitializeComponent();
            RoomCode = roomcode;
            this.label1.Text = "Phòng " + roomcode.ToString();
            if (ListBillInfo.Count != 0)
            {
                BillInfoDTO item = ListBillInfo.First();
                if (item.RoomStatus1 == 1)
                {
                    this.RentButton.Visible = true;
                }
                if (paystatus == 0)
                {
                    this.label13.Text = item.CustomerName1;
                    this.label12.Text = item.CustomerType1.ToString();
                    this.label11.Text = item.IdentityCard1.ToString();
                    this.label10.Text = item.DayCheckIn1.ToString();
                    this.label9.Text = item.RoomType1.ToString();
                    this.label8.Text = item.RoomNote1;
                }
            }
            else
            {
                if (roominfo.RoomStatus == 1)
                    this.RentButton.Visible = true;
                this.label9.Text = roominfo.RoomStyle.ToString();
                if (roominfo.RoomNote != "")
                    this.label8.Text = roominfo.RoomNote;
            }
            mainMenu = mainmenu;
        }
        public fViewRoom()
        {
            InitializeComponent();
        }
        public fViewRoom(List<BillInfoDTO> ListBillInfo, RoomDTO roominfo, MainMenu mainmenu)
        {
            InitializeComponent();            
            if (ListBillInfo.Count != 0)
            {
                BillInfoDTO item = ListBillInfo.First();
                if (item.RoomStatus1 == 1)
                {
                    this.RentButton.Visible = true;
                }
                this.label1.Text  =  item.RoomName1;
                this.label13.Text = item.CustomerName1;
                this.label12.Text = item.CustomerType1.ToString();
                this.label11.Text = item.IdentityCard1.ToString();
                this.label10.Text = item.DayCheckIn1.ToString();
                this.label9.Text  = item.RoomType1.ToString();
                this.label8.Text  = item.RoomNote1;
            }
            else
            {
                if (roominfo.RoomStatus == 1)
                    this.RentButton.Visible = true;
                this.label9.Text = roominfo.RoomStyle.ToString();
                if (roominfo.RoomNote != "")
                    this.label8.Text = roominfo.RoomNote;
            }
            mainMenu = mainmenu;
        }
        public fViewRoom(List<BillInfoDTO> ListBillInfo, RoomDTO roominfo, int roomcode)
        {
            InitializeComponent();
            RoomCode = roomcode;
            this.label1.Text = "Phòng " + roomcode.ToString();
            if (ListBillInfo.Count != 0)
            {
                BillInfoDTO item = ListBillInfo.First();
                if (item.RoomStatus1 == 1)
                {
                    this.RentButton.Visible = true;
                }
                this.label13.Text = item.CustomerName1;
                this.label12.Text = item.CustomerType1.ToString();
                this.label11.Text = item.IdentityCard1.ToString();
                this.label10.Text = item.DayCheckIn1.ToString();
                this.label9.Text = item.RoomType1.ToString();
                this.label8.Text = item.RoomNote1;
            }
            else
            {
                if (roominfo.RoomStatus == 1)
                    this.RentButton.Visible = true;
                this.label9.Text = roominfo.RoomStyle.ToString();
                if (roominfo.RoomNote != "")
                    this.label8.Text = roominfo.RoomNote;
            }
        }
        public fViewRoom(List<BillInfoDTO> ListBillInfo, int roomcode/*, MainMenu mainmenu*/)
        {
            InitializeComponent();
            RoomCode = roomcode;
            this.label1.Text = "Phòng " + roomcode.ToString();
            if (ListBillInfo.Count != 0)
            {
                BillInfoDTO item = ListBillInfo.First();
                if (item.RoomStatus1 == 1)
                {
                    this.RentButton.Visible = true;
                }
                this.label13.Text = item.CustomerName1;
                this.label12.Text = item.CustomerType1.ToString();
                this.label11.Text = item.IdentityCard1.ToString();
                this.label10.Text = item.DayCheckIn1.ToString();
                this.label9.Text = item.RoomType1.ToString();
                this.label8.Text = item.RoomNote1;
            }
            //mainMenu = mainmenu;
        }
        public fViewRoom(fViewRoom fview)
        {
            InitializeComponent();
            this.label13.Text = fview.label13.Text;
            this.label12.Text = fview.label12.Text;
            this.label11.Text = fview.label11.Text;
            this.label10.Text = fview.label10.Text;
            this.label9.Text = fview.label9.Text;
            this.label8.Text = fview.label8.Text;
            this.RentButton.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            fRent f = new fRent(new fRoom(), this.label1.Text);
            this.Hide();
            f.ShowDialog();
            mainMenu.ReLoadRoomStatus();
            mainMenu.ReLoadStatusOfRooms();
            this.Reload(mainMenu.LoadRoomInfo(RoomCode), RoomCode);
            this.Show();
        }
        public void Reload(List<BillInfoDTO> ListBillInfo, int roomcode)
        {
            if (ListBillInfo.Count != 0)
            {
                BillInfoDTO item = ListBillInfo.First();
                if (item.RoomStatus1 == 1)
                {
                    this.RentButton.Visible = true;
                }
                this.label13.Text = item.CustomerName1;
                this.label12.Text = item.CustomerType1.ToString();
                this.label11.Text = item.IdentityCard1.ToString();
                this.label10.Text = item.DayCheckIn1.ToString();
                this.label9.Text = item.RoomType1.ToString();
                this.label8.Text = item.RoomNote1;
                this.RentButton.Visible = false;
            }
        }
        public string GetCustomerName()
        {
            return label13.ToString();
        }
    }
}