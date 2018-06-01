using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    class PayDAO
    {
        private PayDAO() { }

        private static PayDAO instance;

        public static PayDAO Instance
        {
            get
            {
                if (instance == null) instance = new PayDAO(); return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<string> LoadListPayRentID()
        {
            string query = "SELECT MaPT FROM dbo.PHIEUTHUEPHONG WHERE TinhTrangThanhToan=0";

            return DataProvide.Instance.ExecuteReaderListString(query);
        }

        public DataTable RentPay(string RentID)
        {
            string query = "SELECT MaPT,MaPhong,NgayGioBatDauThue,TinhTrangThanhToan FROM dbo.PHIEUTHUEPHONG WHERE MaPT =" + RentID;
            return DataProvide.Instance.ExecuteQuery(query);
        }

        public int GetNewPayID()
        {
            string query = "SELECT MAX(MaHD)+1 FROM dbo.HOADON";
            string ID = DataProvide.Instance.ExecuteReader(query);
            if (ID == "") return 1;
            return int.Parse(ID);
        }

        public void AddPay(string name, string date)
        {
            string query = "EXEC dbo.sp_ThemHoaDon @TenKH , @Ngay ";
            DataProvide.Instance.ExecuteQuery(query, new object[] { name, date });
        }

        public void AddPayDetailByRentID(List<string> strList)
        {
            string query = "EXEC dbo.sp_ThemChiTietHoaDonTheoMaPT @MaPT ";

            foreach (string item in strList)
            {
                DataProvide.Instance.ExecuteQuery(query, new object[] { int.Parse(item) });
            }
        }

        public DataTable PayDetail(string RentID)
        {
            string query = "EXEC dbo.sp_Load_ChiTietThanhToanTheoMaPT @MaPT ";
            return DataProvide.Instance.ExecuteQuery(query, new object[] { int.Parse(RentID) });
        }

        public DataTable ListPayDetail(List<string> ListRentID)
        {
            DataTable data = new DataTable();
            data.Columns.Add(new DataColumn("Mã Phiếu Thuê", typeof(int)));
            data.Columns.Add(new DataColumn("Mã Phòng", typeof(int)));
            data.Columns.Add(new DataColumn("Số Lượng Thuê", typeof(int)));
            data.Columns.Add(new DataColumn("Đơn Giá", typeof(string)));
            data.Columns.Add(new DataColumn("Tổng Tiền Thuê Phòng", typeof(string)));
            data.Columns.Add(new DataColumn("Tổng Tiền Dịch Vụ", typeof(string)));
            data.Columns.Add(new DataColumn("Tổng Tiền", typeof(string)));
            foreach (string item in ListRentID)
            {
                DataTable d = PayDetail(item);
                DataRow row = d.Rows[0];
                data.Rows.Add(row["MaPT"], row["MaPhong"], row["SoLuongThue"], row["DonGia"], row["TongTienThuePhong"], row["TongTienDichVu"], row["ThanhTien"]);
            }

            return data;
        }

        public string GetTotalPrice()
        {
            string query = "SELECT TongTien FROM dbo.HOADON WHERE MaHD = (SELECT MAX(MaHD) FROM dbo.HOADON)";
            return DataProvide.Instance.ExecuteReader(query);
        }

        public void UpdateStatusPay(List<string> ListRentPay_ed)
        {
            string query = "EXEC dbo.sp_CapNhatTinhTrangThanhToan @MaPT";
            foreach (string item in ListRentPay_ed)
            {
                DataProvide.Instance.ExecuteQuery(query, new object[] { int.Parse(item) });
            }
        }
    }
}
