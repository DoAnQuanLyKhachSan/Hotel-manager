using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class RoomDAO
    {
        private RoomDAO() { }
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get
            {
                if (instance==null) instance = new RoomDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        
        public DataTable ExecuteQuery()
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong=p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.TinhTrangPhong=p.TinhTrangPhong";
            return DataProvide.Instance.ExecuteQuery(query);
     
        }
        
    }
}
