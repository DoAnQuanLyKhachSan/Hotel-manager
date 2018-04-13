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
        public fViewRoom(List<BillInfoDTO> ListBillInfo,int roomcode)
        {
            InitializeComponent();
            this.label1.Text = "Phòng " + roomcode.ToString();
            foreach (BillInfoDTO item in ListBillInfo)
                {
                        this.label13.Text = item.CustomerName1;
                        this.label12.Text = item.CustomerType1.ToString();
                        this.label11.Text = item.IdentityCard1.ToString();
                        this.label10.Text = item.DayCheckIn1.ToString();
                        this.label9.Text = item.RoomType1.ToString();
                        this.label8.Text = item.RoomNote1;
                }
        }
    }
}