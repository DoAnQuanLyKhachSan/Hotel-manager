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
    }
}
