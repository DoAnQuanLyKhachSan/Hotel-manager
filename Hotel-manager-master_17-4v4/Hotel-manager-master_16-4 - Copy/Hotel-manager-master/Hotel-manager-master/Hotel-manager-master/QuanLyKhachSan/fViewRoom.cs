﻿using System;
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
<<<<<<< HEAD:Hotel-manager-master_17-4v4/Hotel-manager-master_16-4 - Copy/Hotel-manager-master/Hotel-manager-master/Hotel-manager-master/QuanLyKhachSan/fViewRoom.cs
        MainMenu mainMenu = new MainMenu(1);
        public fViewRoom(List<BillInfoDTO> ListBillInfo,RoomDTO roominfo,int roomcode, MainMenu mainmenu)
=======
        MainMenu mainMenu = new MainMenu();
        public fViewRoom(List<BillInfoDTO> ListBillInfo, RoomDTO roominfo, int roomcode, MainMenu mainmenu)
>>>>>>> 79bd8ce4d26160fc385df522e155bfc60d43b97e:Hotel-manager-master/QuanLyKhachSan/fViewRoom.cs
        {
            InitializeComponent();
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
            mainMenu = mainmenu;
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
        public fViewRoom(List<BillInfoDTO> ListBillInfo, int roomcode, MainMenu mainmenu)
        {
            InitializeComponent();
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
            mainMenu = mainmenu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            fRent f = new fRent(new fRoom(), this.label1.Text, mainMenu);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}