using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class AccountManagementDAO
    {
        private AccountManagementDAO() { }
        private static AccountManagementDAO instance;

        public static AccountManagementDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountManagementDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public DataTable getUserGroupFromDataBase()
        {
            string query = "select MaNhom as 'Mã nhóm',TenNhom as 'Tên nhóm' from dbo.NHOM_NGUOI_DUNG";
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public DataTable getDecentralizationFromDataBase()
        {
            string query = "select MaNhom as 'Mã nhóm' , MaChucNang as 'Mã chức năng' from dbo.PHAN_QUYEN";
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public DataTable getUsersFromDataBase()
        {
            string query = "select TenDangNhap as 'Tên đăng nhập',MatKhau as 'Mật khẩu',MaNhom as 'Mã nhóm' from dbo.NGUOI_DUNG";
            return DataProvide.Instance.ExecuteQuery(query);
        }

       public int insertGroupUser(int _groupCode ,string _groupName)
       {
            string query = "insert into dbo.NHOM_NGUOI_DUNG(MaNhom,TenNhom) values("+_groupCode+",'"+_groupName+"')";
            return DataProvide.Instance.ExecuteNonQuery(query);
       }

       public bool CheckExitsGroupCode(int _groupCode)
        {
            
            string query = "if exists (select MaNhom from NHOM_NGUOI_DUNG where MaNhom ="+_groupCode+") select 1";
            DataTable rs = DataProvide.Instance.ExecuteQuery(query);
            //rs tra ve gia tri 1 neu ma nhom da co trong database
            if (rs.Rows.Count > 0) return true;
            else
            {
                return false;
            }
        }

        public int insertPhanQuyen(int _groupCode, int _functionCode)
        {
            string query = "insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(" + _groupCode + "," + _functionCode + ")";
            return DataProvide.Instance.ExecuteNonQuery(query);
        }

        public bool CheckExitsPhanQuyen(int _groupCode,int _functionCode)
        {
            string query = "if exists (select MaNhom,MaChucNang from PHAN_QUYEN where MaNhom =" + _groupCode + " AND MaChucNang ="+_functionCode+") select 1";
            DataTable rs = DataProvide.Instance.ExecuteQuery(query);
            //rs tra ve gia tri 1 neu ma nhom da co trong database
            if (rs.Rows.Count > 0) return true;
            else
            {
                return false;
            }
        }

        public int insertUser(string _userName,string _userPass , int _groupCode)
        {
            string query = "insert into dbo.NGUOI_DUNG(TenDangNhap,MatKhau,MaNhom) values(N'" + _userName + "',N'" + _userPass + "'," + _groupCode + ")";
            return DataProvide.Instance.ExecuteNonQuery(query);
        }

        public bool CheckExitsUser(string _userName)
        {
            string query = "if exists (select TenDangNhap from NGUOI_DUNG where TenDangNhap =N'" + _userName +  "') select 1";
            DataTable rs = DataProvide.Instance.ExecuteQuery(query);
            //rs tra ve gia tri 1 neu ma nhom da co trong database
            if (rs.Rows.Count > 0) return true;
            else
            {
                return false;
            }
        }

        public string deleteGroupUser(int GroupCode)
        {
            return "DELETE FROM dbo.NHOM_NGUOI_DUNG WHERE MaNhom =" + GroupCode;
        }

        public string deletePhanQuyenVoiMaNhom(int GroupCode)
        {
            return "DELETE FROM dbo.PHAN_QUYEN WHERE MaNhom =" + GroupCode;
        }

        public string deleteUserVoiMaNhom(int GroupCode)
        {
            return "DELETE FROM dbo.NGUOI_DUNG WHERE MaNhom = " + GroupCode;
        }


        public string deletePhanQuyen(int GroupCode,int FunctionCode)
        {
            return "DELETE FROM dbo.PHAN_QUYEN WHERE MaNhom =" + GroupCode + " AND MaChucNang =" + FunctionCode;
        }

        public string deleteUser(string userName)
        {
            return "DELETE FROM dbo.NGUOI_DUNG WHERE TenDangNhap =N'" + userName + " ' ";
        }

        public bool CheckExitsGroupEdit(int _groupCode, string _groupName)
        {

            string query = "if exists (select MaNhom from NHOM_NGUOI_DUNG where MaNhom =" + _groupCode + " AND TenNhom=N'" + _groupName + "') select 1";
            DataTable rs = DataProvide.Instance.ExecuteQuery(query);
            //rs tra ve gia tri 1 neu ma nhom da co trong database
            if (rs.Rows.Count > 0) return true;
            else
            {
                return false;
            }
        }
        public bool CheckExitsUserEdit(string _userName,string _userPass,int _groupCode)
        {
            string query = "if exists (select TenDangNhap from NGUOI_DUNG where TenDangNhap =N'" + _userName + "' AND MatKhau =N'"+_userPass+"' AND MaNhom = "+_groupCode+") select 1";
            DataTable rs = DataProvide.Instance.ExecuteQuery(query);
            //rs tra ve gia tri 1 neu ma nhom da co trong database
            if (rs.Rows.Count > 0) return true;
            else
            {
                return false;
            }
        }
        public int UpdateGroupUser( int _groupCodeInDex, string _groupCode = null,string _groupName = null)
        {
            string query = null;
            if (_groupCode == null)
            {
                query = "EXEC capNhatNhomNguoiDung @MaNhomIndex , null , @TenNhom ";
                return DataProvide.Instance.ExecuteNonQuery(query, new object[] { _groupCodeInDex, _groupName });
            }
            else
            {
                if (_groupName == null)
                {
                    query = "EXEC capNhatNhomNguoiDung @MaNhomIndex , @MaNhom ";
                    return DataProvide.Instance.ExecuteNonQuery(query, new object[] { _groupCodeInDex, _groupCode });
                }
                else
                {
                    query = "EXEC capNhatNhomNguoiDung @MaNhomIndex , @MaNhom , @TenNhom ";
                    return DataProvide.Instance.ExecuteNonQuery(query, new object[] { _groupCodeInDex, _groupCode, _groupName });
                }
            }
            
        }

       
        public int UpdatePhanQuyen(int _groupCode, int _functionCode,int _groupCodeInDex,int _functionCodeIndex)
        {
            string query = "UPDATE dbo.PHAN_QUYEN SET MaNhom =" + _groupCode + ",MaChucNang =" + _functionCode + " WHERE MaNhom = " + _groupCodeInDex + " AND MaChucNang = " + _functionCodeIndex;
            return DataProvide.Instance.ExecuteNonQuery(query);
        }
        public int UpdateUser(string _userName, string _userPass, int _groupCode,string _userNameIndex)
        {
            string query = "UPDATE dbo.NGUOI_DUNG SET TenDangNhap = N'" + _userName + "',MatKhau=N'" + _userPass + "',MaNhom =" + _groupCode + "WHERE TenDangNhap = N'" + _userNameIndex+"'";
            return DataProvide.Instance.ExecuteNonQuery(query);
        }

        public bool checkShowForm(int groupCode,string nameForm)
        {
            string query = "select MaChucNang from CHUC_NANG where TenManHinhDuocLoad = N'" + nameForm + "'";
            int rs = int.Parse(DataProvide.Instance.ExecuteReader(query));
            if (CheckExitsPhanQuyen(groupCode, rs) == true) return true;
            return false;
        }
        public DataTable getListChucNang()
        {
            string query = "select MaChucNang as 'Mã chức năng',TenChucNang as 'Tên chức năng' from dbo.CHUC_NANG";
            return DataProvide.Instance.ExecuteQuery(query);
        }



    }

}
