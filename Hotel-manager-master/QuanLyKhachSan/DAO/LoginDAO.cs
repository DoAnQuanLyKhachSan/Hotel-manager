using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class LoginDAO
    {
        private LoginDAO() { }
        private static LoginDAO instance;

        public static LoginDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoginDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public bool Login(string userName,string userPass)
        {
            string query = "if exists (select TenDangNhap,MatKhau from NGUOI_DUNG where TenDangNhap = N'" + userName + "' AND MatKhau = N'" + userPass + "')select 1";
            DataTable rs = DataProvide.Instance.ExecuteQuery(query);
            if (rs.Rows.Count > 0) return true;
            return false;
        }
        public bool checkUserName(string userName)
        {
            string query = "if exists (select TenDangNhap from NGUOI_DUNG where TenDangNhap = N'" + userName + "')select 1";
            DataTable rs = DataProvide.Instance.ExecuteQuery(query);
            if (rs.Rows.Count > 0) return true;
            return false;
        }

        

    }
}
