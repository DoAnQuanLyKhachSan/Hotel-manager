using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class BillDTO
    {

        public BillDTO(int roomcode,DateTime daycheckin)
        {
            this.RoomCode1 = roomcode;
            this.DayCheckIn1 = daycheckin;
        }
        public BillDTO(DataRow row)
        {
            this.RoomCode1 = (int)row["MaPhong"];
            this.DayCheckIn1 = (DateTime)row["NgayGioBatDauThue"];
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

        private DateTime DayCheckIn;

        private int RoomCode;

        private int RoomType;
    }
}
