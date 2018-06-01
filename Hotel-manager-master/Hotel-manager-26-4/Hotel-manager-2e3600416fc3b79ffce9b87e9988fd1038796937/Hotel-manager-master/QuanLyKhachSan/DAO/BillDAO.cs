using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set
            {
                instance = value;
            }
        }
        private BillDAO() { }
        public int GetBillIDByRoomcode(int roomcode)
        {
            DataTable data = DataProvide.Instance.ExecuteQuery("select * from PHIEUTHUEPHONG where MaPhong =" + roomcode.ToString());
            if(data.Rows.Count>0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.RoomCode1;
            }
            return -1;
        }
        public int GetBillIDByCustomerName(string customername)
        {
            DataTable data = DataProvide.Instance.ExecuteQuery("select p.MaPT,p.MaPhong,p.MaHinhThucThue,p.NgayGioBatDauThue,p.SoKhach,p.TinhTrangThanhToan from CHITIET_PHIEUTHUE c join PHIEUTHUEPHONG p on c.MaPT=p.MaPT where TenKhachHang=" + customername);
            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.RoomCode1;
            }
            return -1;
        }
        public RoomDTO GetRoomInfoByRoomcode(int roomcode)
        {
            DataTable data = DataProvide.Instance.ExecuteQuery("select * from phong where maphong =" + roomcode.ToString());
            if (data.Rows.Count > 0)
            {
                RoomDTO bill = new RoomDTO(data.Rows[0]);
                return bill;
            }
            return null;
        }
        public CustomerDTO GetRoomInfoByCustomerName(string customername)
        {
            DataTable data = DataProvide.Instance.ExecuteQuery("select * from CHITIET_PHIEUTHUE c join PHIEUTHUEPHONG p on c.MaPT=p.MaPT  where TenKhachHang = " + "'"+ customername + "'");
            if (data.Rows.Count > 0)
            {
                CustomerDTO bill = new CustomerDTO(data.Rows[0]);
                return bill;
            }
            return null;
        }
        public List<BillDTO> GetListBillInfo(int roomcode)
        {
            List<BillDTO> ListBill = new List<BillDTO>();
            DataTable data = DataProvide.Instance.ExecuteQuery(GetlistBillInfoQuery + roomcode.ToString());
            foreach (DataRow item in data.Rows)
            {
                BillDTO info = new BillDTO(item);
                ListBill.Add(info);
            }
            return ListBill;
        }
        public string GetlistBillInfoQuery = "select MaPhong,NgayGioBatDauThue,TinhTrangThanhToan from PHIEUTHUEPHONG where MaPhong =";
    }
}
