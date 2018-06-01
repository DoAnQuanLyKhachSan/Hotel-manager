using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class StaffDAO
    {
        private StaffDAO() { }
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get
            {
                if (instance == null) instance = new StaffDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable loadStaff()
        {
            string query = "select HoTen as 'Họ tên',NgaySinh as 'Ngày sinh',NgayKyHopDong as 'Ngày kí hợp đồng',SoHopDong as 'Số hợp đồng',HeSo as 'Hệ số lương',TenPhongBan as 'Phòng ban',TenChucVu as 'Chức vụ' from(BAC_LUONG bl inner join NHAN_VIEN nv on bl.MaBacLuong=nv.MaBacLuong inner join CHUC_VU cv on nv.MaChucVu=cv.MaChucVu ) inner join PHONG_BAN pb on pb.MaPhongBan=nv.MaPhongBan ";
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public DataTable traVeMaBacLuong()
        {
            string query = "select MaBacLuong from BAC_LUONG ";
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public DataTable traVeTenVaMaPhongBan()
        {
            string query = "select MaPhongBan,TenPhongBan from PHONG_BAN ";
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public DataTable traVeTenVaMaChucVu()
        {
            string query = "select MaChucVu,TenChucVu from CHUC_VU ";
            return DataProvide.Instance.ExecuteQuery(query);
        }

        public int soHDLonNhat()
        {
            string query = "exec TraVeSoHDLonNhat";
            return DataProvide.Instance.ExecuteNonQuery(query);
        }
        public int AddStaffToDataBase(string hoTen,DateTime ntns,DateTime nkhd,int soHD,int MaBacLuong,int MaPhongBan,int MaChucVu)
        {
            string query = "EXEC AddStaffToDataBase @HoTen , @NgaySinh , @NgayKiHopDong , @SoHopDong , @MaBacLuong , @MaPhongBan , @MaChucVu  ";
            return DataProvide.Instance.ExecuteNonQuery(query,new object[] { hoTen, ntns, nkhd, soHD, MaBacLuong, MaPhongBan, MaChucVu });
        }
        public int returnStaffCode(string _staffName)
        {
            string query = "select MaNV from NHAN_VIEN where HoTen=N'" + _staffName+"'";
            return int.Parse(DataProvide.Instance.ExecuteReader(query));
        }
        public string deleteStaffDatabaseQuery(int _staffCode) { return "DELETE FROM dbo.NHAN_VIEN WHERE MaNV ="+_staffCode; }
        public int updateStaff(int MaNV,int MaBacLuong,int MaPhongBan, int MaChucVu)
        {
            string query = "EXEC dbo.UpdateRoomToDataBase @MaNV , @MaBacLuong , @MaPhongBan , @MaChucVu ";
            return DataProvide.Instance.ExecuteNonQuery(query, new object[] { MaNV, MaBacLuong, MaPhongBan, MaChucVu });
        }
    }
}
