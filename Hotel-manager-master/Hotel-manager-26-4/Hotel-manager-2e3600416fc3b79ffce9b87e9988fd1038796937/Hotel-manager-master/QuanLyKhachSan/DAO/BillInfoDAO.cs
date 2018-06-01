using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
   public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public BillInfoDAO()
        {

        }
        public List<BillInfoDTO> GetListBillInfo(int roomcode)
        {
            List<BillInfoDTO> ListBillInfo = new List<BillInfoDTO>();
            DataTable data = DataProvide.Instance.ExecuteQuery(GetlistBillInfoQuery+roomcode.ToString());
            foreach(DataRow item in data.Rows)
            {
                BillInfoDTO info = new BillInfoDTO(item);
                ListBillInfo.Add(info);
            }
            return ListBillInfo;
        }
        private string GetlistBillInfoQuery = "select Phong.MaPhong,Phong.TinhTrangPhong,MaLoaiPhong,NgayGioBatDauThue,CMND,TenKhachHang,MaLoaiKhachHang,GhiChu,TenPhong from((PHONG join PHIEUTHUEPHONG on PHONG.MaPhong= PHIEUTHUEPHONG.MaPhong) join CHITIET_PHIEUTHUE on PHIEUTHUEPHONG.MaPT=CHITIET_PHIEUTHUE.MaPT) where PHONG.MaPhong =";
    }
}
