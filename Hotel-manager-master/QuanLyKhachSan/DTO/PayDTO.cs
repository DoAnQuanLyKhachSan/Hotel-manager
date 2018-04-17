using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class PayDTO
    {


        public PayDTO() { }


        public PayDTO(DataRow row, int type)
        {
            if (type == 1)
            {
                this.RoomID = (int)row["MaPhong"];
                this.BeginDay = row["NgayBatDau"].ToString();
                this.StatusPay = (int)row["TinhTrangThanhToan"];

            }
            if (type == 0)
            {
                this.PayDetailID = (int)row["MaCTPT"];
                this.NameCus = row["TenKhachHang"].ToString();
                this.RoomID = (int)row["MaPhong"];
                this.BeginDay = row["NgayBatDau"].ToString(); ;
            }
            if (type == 2)
            {
                this.RoomID = (int)row["MaPhong"];
                this.NameCus = row["TenKhachHang"].ToString();
                this.NumOfDayRent = (int)row["SoNgayThue"];
                this.Price = row["DonGia"].ToString();
                this.TotalMoney = row["ThanhTien"].ToString();

            }

        }

        private string totalMoney;
        private string price;
        private int numOfDayRent;
        private string nameCus;
        private int payDetailID;
        private int statusPay;
        private string beginDay;
        private int roomID;

        public string BeginDay
        {
            get
            {
                return beginDay;
            }

            set
            {
                beginDay = value;
            }
        }

        public int RoomID
        {
            get
            {
                return roomID;
            }

            set
            {
                roomID = value;
            }
        }

        public int StatusPay
        {
            get
            {
                return statusPay;
            }

            set
            {
                statusPay = value;
            }
        }

        public int PayDetailID
        {
            get
            {
                return payDetailID;
            }

            set
            {
                payDetailID = value;
            }
        }

        public string NameCus
        {
            get
            {
                return nameCus;
            }

            set
            {
                nameCus = value;
            }
        }

        public int NumOfDayRent
        {
            get
            {
                return numOfDayRent;
            }

            set
            {
                numOfDayRent = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string TotalMoney
        {
            get
            {
                return totalMoney;
            }

            set
            {
                totalMoney = value;
            }
        }
    }
}
