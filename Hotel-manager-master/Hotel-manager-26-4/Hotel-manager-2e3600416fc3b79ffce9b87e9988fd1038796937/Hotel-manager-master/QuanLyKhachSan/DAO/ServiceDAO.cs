using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    class ServiceDAO
    {
        private ServiceDAO() { }

        private static ServiceDAO instance;

        public static ServiceDAO Instance
        {
            get
            {
                if (instance == null) instance = new ServiceDAO(); return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<string> getListCusName(int RentID)
        {
            string query = "SELECT ctt.TenKhachHang FROM dbo.PHIEUTHUEPHONG pt JOIN dbo.CHITIET_PHIEUTHUE ctt ON ctt.MaPT = pt.MaPT WHERE pt.MaPT=" + RentID.ToString() ;

            return DataProvide.Instance.ExecuteReaderListString(query);
        }

        public List<string> getListServiceName()
        {
            string query = "SELECT TenDV FROM dbo.DICHVU";

            return DataProvide.Instance.ExecuteReaderListString(query);
        }

        public int getServiceID(string ServiceName)
        {
            string query = "SELECT MaDV FROM DICHVU WHERE TenDV = N'" + ServiceName + "'";
            return  int.Parse(DataProvide.Instance.ExecuteReader(query));
        }

        public void CreateDetailUseService(int MaPT, int MaDV, string TenKH, string NgayGio, int SoLuong)
        {
            string query = "EXEC dbo.sp_ThemChiTiet_SuDungDV @MaPT , @MaDV , @TenKH , @NgayGio , @SoLuong";
            DataProvide.Instance.ExecuteQuery(query, new object[] { MaPT, MaDV, TenKH, NgayGio, SoLuong });
        }

        public DataTable  Load_HistoryService(int MaPT)
        {
            string query = "SELECT * FROM dbo.CHITIET_SUDUNGDV WHERE MaPT =" + MaPT.ToString();
            return DataProvide.Instance.ExecuteQuery(query);
        }

    }
}
