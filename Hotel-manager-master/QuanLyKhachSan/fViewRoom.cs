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
        MainMenu mainMenu = new MainMenu();
        public fViewRoom(List<BillInfoDTO> ListBillInfo,RoomDTO roominfo,int roomcode, MainMenu mainmenu)
        {
            InitializeComponent();
            this.label1.Text = "Phòng " + roomcode.ToString();
            if (ListBillInfo.Count !=0)
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
                if(roominfo.RoomStatus==1)
                    this.RentButton.Visible = true;
                this.label9.Text = roominfo.RoomStyle.ToString();
                if(roominfo.RoomNote!="")
                    this.label8.Text = roominfo.RoomNote;
            }
            mainMenu = mainmenu;            
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