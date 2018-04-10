using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class CustomerDAO
    {
        private CustomerDAO() { }
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null) instance = new CustomerDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public int createMaxCustomerCodeToDataBase()
        {
            string query = "SELECT MAX(MaKhachHang) FROM KHACHHANG";
            int maxCustomerCodeInDatabase = int.Parse(DataProvide.Instance.ExecuteReader(query).ToString());
            return maxCustomerCodeInDatabase + 1;
        }

        public int returnCustomerStyleCode(string StyleName)
        {
            string query = "select MaLoaiKhachHang from LOAI_KHACHHANG WHERE TenLoaiKhachHang = N'" + StyleName + "'";
            return  int.Parse(DataProvide.Instance.ExecuteReader(query).ToString());
        }

    }
}
