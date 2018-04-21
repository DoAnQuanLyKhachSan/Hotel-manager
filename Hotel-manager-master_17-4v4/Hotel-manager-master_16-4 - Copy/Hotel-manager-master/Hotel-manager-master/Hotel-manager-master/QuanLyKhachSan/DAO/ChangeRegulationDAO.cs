using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    class ChangeRegulationDAO
    {

        private ChangeRegulationDAO() { }
        private static ChangeRegulationDAO instance;

        public static ChangeRegulationDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChangeRegulationDAO();
                return ChangeRegulationDAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable LoadListRate()
        {
            string query = "SELECT * FROM dbo.THAMSO WHERE  TenThamSo=N'HeSoPhuThu' OR TenThamSo=N'TyLePhuThu'";
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public DataTable LoadListRoomType()
        {
            string query = "SELECT * FROM dbo.LOAI_PHONG";
            return DataProvide.Instance.ExecuteQuery(query);

        }

        public DataTable LoadListCusType()
        {
            string query = "SELECT * FROM dbo.LOAI_KHACHHANG";
            return DataProvide.Instance.ExecuteQuery(query);
        }

        public List<int> getListRoomTypeCode()
        {

            List<int> listID = new List<int>();
            string query = "SELECT MaLoaiPhong FROM dbo.LOAI_PHONG";
            
            DataTable data = DataProvide.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {

                listID.Add((int)item["MaLoaiPhong"]);
            }

            return listID;
        }

        public List<int> getListCusTypeCode()
        {

            List<int> listID = new List<int>();
            string query = "SELECT MaLoaiKhachHang FROM dbo.LOAI_KHACHHANG";
            
            DataTable data =  DataProvide.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {

                listID.Add((int)item["MaLoaiKhachHang"]);
            }

            return listID;
        }



        public string getRoomTypeName(int idRoom)
        {
            string _Name = null;
            string query = "SELECT TenLoaiPhong FROM dbo.LOAI_PHONG WHERE MaLoaiPhong=" + idRoom;

            DataTable data = DataProvide.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                _Name = item["TenLoaiPhong"].ToString();
            }

            return _Name;

        }

        public string getMaxCus()
        {
            string max = null;
            string query = "SELECT GiaTri FROM dbo.THAMSO WHERE TenThamSo=N'KhachToiDa'";
            DataTable data = DataProvide.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                max = item["GiaTri"].ToString();
            }

           return max;
        }

        public void UpdatePrice(int _ID, double _Price) //chạy Store Procudure Update lại đơn giá 
        {
            string query = "EXEC dbo.sp_CapNhatDonGiaLoaiPhong @MaLP , @Gia ";
            DataProvide.Instance.ExecuteQuery(query, new object[] {_ID, _Price });
        }

        public void AddRoomType(int _ID, string _Name, double _Price) //Chạy Strore Procudure Thêm mới loại phòng
        {
            string query = "EXEC dbo.sp_ThemMoiLoaiPhong @MaLP , @TenLP , @Gia ";
            DataProvide.Instance.ExecuteQuery(query, new object[] {_ID, _Name, _Price });
        }

        public void AddCusType (int _ID, string _Name)  ////Chạy Strore Procudure Thêm mới loại Khách
        {
            string query = "EXEC dbo.sp_ThemMoiLoaiKhach @MaLK , @TenLK";
            DataProvide.Instance.ExecuteQuery(query, new object[] {_ID, _Name });
        }

        public void UpdateMaxCus(int _max)
        {
            string query = "EXEC dbo.sp_CapNhatKhachToiDa @Maxx ";
            DataProvide.Instance.ExecuteQuery(query, new object[] {_max});
        }

        public void UpdateRate1(float n)
        {
            string query = "EXEC dbo.sp_CapNhatTyLePhuThu @TyLe ";
            DataProvide.Instance.ExecuteQuery(query, new object[] { n });
        }

        public void UpdateRate2(float n)
        {
            string query = "EXEC dbo.sp_CapNhatHeSoPhuThu @HeSo ";
            DataProvide.Instance.ExecuteQuery(query, new object[] { n });
        }


        public bool IsNumber(string pValue) // hàm kiểm tra chuỗi có phải là Số hay không
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

    }
}
