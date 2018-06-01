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
        public BillInfoDTO(int roomcode,int roomtype,DateTime daycheckin,string roomname,string customername,int customertype,int identitycard, int roomstatus, string roomnote="")
        {
            this.RoomCode1 = roomcode;
            this.RoomType1 = roomtype;
            this.DayCheckIn1 = daycheckin;
            this.CustomerName1 = customername;
            this.CustomerType1 = customertype;
            this.IdentityCard1 = identitycard;
            this.RoomName1 = roomname;
            this.RoomNote1 = roomnote;
            this.RoomStatus1 = roomstatus;
        }

        public BillInfoDTO(DataRow row)
        {
            this.RoomCode1 = (int)row["MaPhong"];
            this.RoomName1 = (string)row["TenPhong"];
            this.CustomerName1 = (string)row["TenKhachHang"];
            this.CustomerType1 = (int)row["MaLoaiKhachHang"];
            this.IdentityCard1 = (int)row["CMND"];
            this.RoomNote1 = (String)row["GhiChu"];
            this.DayCheckIn1 = (DateTime)row["NgayGioBatDauThue"];
            this.RoomType1 = (int)row["MaLoaiPhong"];
            this.RoomStatus1 = (int)row["TinhTrangPhong"];
        }
        private int RoomStatus;

        private int RoomCode;

        private string RoomName;

        private int RoomType;

        private string CustomerName;

        private int CustomerType;

        private int IdentityCard;

        private string RoomNote;

        private DateTime DayCheckIn;

        public int RoomCode1
        {
            get
            {
                return RoomCode;
            }

            set
            {
                RoomCode = value;
            }
        }

        public string RoomName1
        {
            get
            {
                return RoomName;
            }

            set
            {
                RoomName = value;
            }
        }

        public int RoomType1
        {
            get
            {
                return RoomType;
            }

            set
            {
                RoomType = value;
            }
        }

        public string CustomerName1
        {
            get
            {
                return CustomerName;
            }

            set
            {
                CustomerName = value;
            }
        }

        public int CustomerType1
        {
            get
            {
                return CustomerType;
            }

            set
            {
                CustomerType = value;
            }
        }

        public int IdentityCard1
        {
            get
            {
                return IdentityCard;
            }

            set
            {
                IdentityCard = value;
            }
        }

        public string RoomNote1
        {
            get
            {
                return RoomNote;
            }

            set
            {
                RoomNote = value;
            }
        }

        public DateTime DayCheckIn1
        {
            get
            {
                return DayCheckIn;
            }

            set
            {
                DayCheckIn = value;
            }
        }

        public int RoomStatus1
        {
            get
            {
                return RoomStatus;
            }
            set
            {
                RoomStatus = value;
            }
        }
    }
}
