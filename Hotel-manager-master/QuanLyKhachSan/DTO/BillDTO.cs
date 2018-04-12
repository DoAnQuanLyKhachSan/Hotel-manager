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
            this.DayCheckIn = daycheckin;
        }
        public BillDTO(DataRow row)
        {
            this.RoomCode1 = (int)row["MaPhong"];
            this.DayCheckIn = (DateTime)row["NgayBatDau"];
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


        public DateTime DayCheckIn1 { get => DayCheckIn; set => DayCheckIn = value; }

        public int RoomType1 { get => RoomType; set => RoomType = value; }
        public int RoomCode1 { get => RoomCode; set => RoomCode = value; }

        private DateTime DayCheckIn;

        private int RoomCode;

        private int RoomType;
    }
}
