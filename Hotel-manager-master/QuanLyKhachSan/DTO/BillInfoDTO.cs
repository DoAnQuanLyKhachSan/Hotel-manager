using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class BillInfoDTO
    {
        public BillInfoDTO(int roomcode,int roomtype,DateTime daycheckin,string roomname,string customername,int customertype,int identitycard,string roomnote="")
        {
            this.RoomCode = roomcode;
            this.RoomType = roomtype;
            this.DayCheckIn = daycheckin;
            this.CustomerName = customername;
            this.CustomerType = customertype;
            this.IdentityCard = identitycard;
            this.RoomName = roomname;
            this.RoomNote = roomnote;
        }

        public BillInfoDTO(DataRow row)
        {
            this.RoomCode = (int)row["MaPhong"];
            this.RoomName = (string)row["TenPhong"];
            this.CustomerName = (string)row["TenKhachHang"];
            this.CustomerType = (int)row["MaLoaiKhachHang"];
            this.IdentityCard = (int)row["CMND"];
            this.RoomNote = (String)row["GhiChu"];
            this.DayCheckIn = (DateTime)row["NgayBatDau"];
            this.RoomType = (int)row["MaLoaiPhong"];
        }

        private int RoomCode;

        private string RoomName;

        private int RoomType;

        private string CustomerName;

        private int CustomerType;

        private int IdentityCard;

        private string RoomNote;

        private DateTime DayCheckIn;

        public int RoomCode1 { get => RoomCode; set => RoomCode = value; }
        public string RoomName1 { get => RoomName; set => RoomName = value; }
        public int RoomType1 { get => RoomType; set => RoomType = value; }
        public string CustomerName1 { get => CustomerName; set => CustomerName = value; }
        public int CustomerType1 { get => CustomerType; set => CustomerType = value; }
        public int IdentityCard1 { get => IdentityCard; set => IdentityCard = value; }
        public string RoomNote1 { get => RoomNote; set => RoomNote = value; }
        public DateTime DayCheckIn1 { get => DayCheckIn; set => DayCheckIn = value; }
    }
}
