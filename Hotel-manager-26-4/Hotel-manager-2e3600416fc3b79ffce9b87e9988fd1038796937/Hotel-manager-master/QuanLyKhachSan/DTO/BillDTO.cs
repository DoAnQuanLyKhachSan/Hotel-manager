using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class BillDTO
    {

        public BillDTO(int roomcode,DateTime daycheckin,int paystatus)
        {
            this.RoomCode1 = roomcode;
            this.DayCheckIn1 = daycheckin;
            this.PayStatus = paystatus;
        }
        public BillDTO(DataRow row)
        {
            this.RoomCode1 = (int)row["MaPhong"];
            this.DayCheckIn1 = (DateTime)row["NgayGioBatDauThue"];
            this.PayStatus1 = (int)row["TinhTrangThanhToan"];
        }

        private String CustomerName;

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

        public int PayStatus1
        {
            get
            {
                return PayStatus;
            }
            set
            {
                PayStatus = value;
            }
        }

        private DateTime DayCheckIn;

        private int RoomCode;

        private int RoomType;
        private int PayStatus;
    }
}
