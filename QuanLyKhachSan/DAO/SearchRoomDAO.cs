using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan;


namespace QuanLyKhachSan.DAO
{
    public class SearchRoomDAO
    {
        private SearchRoomDAO() { }
        private static SearchRoomDAO instance;

        public static SearchRoomDAO Instance
        {
            get
            {
                if (instance == null) instance = new SearchRoomDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public DataTable ExecuteQuerySearchCodeRoom(string _str)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.TinhTrangPhong = p.TinhTrangPhong where p.MaPhong = " + _str;
            return DataProvide.Instance.ExecuteQuery(query);
        }


        public DataTable ExecuteQuerySearchStyleRoom(string _str)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.MaLoaiPhong = " + _str;
            return DataProvide.Instance.ExecuteQuery(query);
        }

      
        public DataTable ExecuteQuerySearchStatusRoom(string _str)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.TinhTrangPhong = " + _str;
            return DataProvide.Instance.ExecuteQuery(query);
        }

    }
}
