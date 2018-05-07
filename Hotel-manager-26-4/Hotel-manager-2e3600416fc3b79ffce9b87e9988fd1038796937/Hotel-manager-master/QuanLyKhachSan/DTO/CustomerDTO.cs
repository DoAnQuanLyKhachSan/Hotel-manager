using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class CustomerDTO
    {
        private string customerName;
        private int customerStyle;
        private int customerCMND;
        private string customerAddress;
        private int roomcode;
        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public int CustomerStyle
        {
            get
            {
                return customerStyle;
            }

            set
            {
                customerStyle = value;
            }
        }

        public int CustomerCMND
        {
            get
            {
                return customerCMND;
            }

            set
            {
                customerCMND = value;
            }
        }

        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }

            set
            {
                customerAddress = value;
            }
        }

        public int Roomcode
        {
            get
            {
                return roomcode;
            }
            set
            {
                roomcode = value;
            }
        }

        public CustomerDTO() { }
        public CustomerDTO(int roomcode, string customerName  , int customerStyle , int customerCMND ,string customerAddress)
        {
            this.roomcode = roomcode;
            this.customerName = customerName;
            this.customerStyle = customerStyle;
            this.customerCMND = customerCMND;
            this.customerAddress = customerAddress;
        }

        public CustomerDTO(DataRow row)
        {
            this.roomcode = (int)row["MaPhong"];
            this.customerName = (string)row["TenKhachHang"];
            this.customerStyle = (int)row["MaLoaiKhachHang"];
            this.customerCMND = (int)row["CMND"];
            this.customerAddress = (String)row["DiaChi"];
        }
    }
}
