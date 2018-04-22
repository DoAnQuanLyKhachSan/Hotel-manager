﻿using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PayDAO
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

      

        public List<PayDTO> getListPayDetailByRoom(int MaPhong)
        {
            List<PayDTO> list = new List<PayDTO>();
            string query = "EXEC dbo.sp_ChiTietThanhToanTheoPhong @MaPhong ";

            DataTable data = DataProvide.Instance.ExecuteQuery(query, new object[] { MaPhong });

            foreach (DataRow item in data.Rows)
            {

                PayDTO pay = new PayDTO(item, 2);
                list.Add(pay);
            }

            return list;

        }

        public List<PayDTO> getListPayDetailByCusName(string name)
        {
            List<PayDTO> list = new List<PayDTO>();
            string query = "EXEC dbo.sp_ChiTietThanhToanTheoTenKhach @TenKH ";

            DataTable data = DataProvide.Instance.ExecuteQuery(query, new object[] { name });

            foreach (DataRow item in data.Rows)
            {
                PayDTO pay = new PayDTO(item, 2);
                list.Add(pay);
            }

            return list;

        }



        public List<PayDTO> getRoomPay(int MaPhong)
        {

            List<PayDTO> list = new List<PayDTO>();
            string query = "EXEC dbo.sp_getPhongThanhToan @MaPhong";

            DataTable data = DataProvide.Instance.ExecuteQuery(query, new object[] { MaPhong });

            foreach (DataRow item in data.Rows)
            {

                PayDTO pay = new PayDTO(item, 1);
                list.Add(pay);
            }

            return list;
        }

        public List<PayDTO> getCusPay(string name)
        {

            List<PayDTO> list = new List<PayDTO>();
            string query = "EXEC dbo.sp_getKhachHangThanhToan @TenKH ";

            DataTable data = DataProvide.Instance.ExecuteQuery(query, new object[] { name });

            foreach (DataRow item in data.Rows)
            {

                PayDTO pay = new PayDTO(item, 0);
                list.Add(pay);
            }

            return list;
        }


        public List<string> getPayData(int n)
        {
            List<string> addrList = new List<string>();
            string query;
            if (n == 1)
            { query = "EXEC dbo.sp_getListPhongCanThanhToan"; }
            else
            { query = "EXEC dbo.sp_getListKhachCanThanhToan"; }

            DataTable data = DataProvide.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (n == 1)
                    addrList.Add(item["MaPhong"].ToString());
                else
                    addrList.Add(item["TenKhachHang"].ToString());

            }
            return addrList;
        }

        public void ListRoomPayToTable(List<PayDTO> listPay, DataTable data)
        {
            foreach (PayDTO item in listPay)
            {
                DataRow row = data.NewRow();
                row["MaPhong"] = item.RoomID;
                row["NgayBatDauThue"] = item.BeginDay;
                row["TinhTrangThanhToan"] = item.StatusPay;

                data.Rows.Add(row);
            }
        }

        public void ListCusPayToTable(List<PayDTO> listPay, DataTable data)
        {
            foreach (PayDTO item in listPay)
            {
                DataRow row = data.NewRow();
                row["MaCTPT"] = item.PayDetailID;
                row["TenKhachHang"] = item.NameCus;
                row["MaPhong"] = item.RoomID;
                row["NgayBatDauThue"] = item.BeginDay;

                data.Rows.Add(row);
            }
        }
        public bool CompareString(string s, List<string> list)
        {
            foreach (string item in list)
            {
                if (item == s) return true;
            }
            return false;
        }

        public DataTable PayDetailByRoom(int id)
        {
            string query = "EXEC dbo.sp_ChiTietThanhToanTheoPhong @MaPhong ";
            return DataProvide.Instance.ExecuteQuery(query, new object[] { id });
        }


        public void ListPayDetailToTable(List<PayDTO> listPay, DataTable data)
        {
            foreach (PayDTO item in listPay)
            {
                DataRow row = data.NewRow();
                row["MaPhong"] = item.RoomID;
                row["TenKhachHang"] = item.NameCus;
                row["SoNgayThue"] = item.NumOfDayRent;
                row["DonGia"] = item.Price;
                row["TongTienPhong"] = item.TotalMoney;

                data.Rows.Add(row);
            }
        }

        public string getTotalPrice()
        {
            string totalPrice = null;
            string query = "SELECT TongTien FROM dbo.HOADON WHERE MaHD = (SELECT MAX(MaHD) FROM dbo.HOADON)";
            DataTable data = DataProvide.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                totalPrice = row["TongTien"].ToString();
            }

            return totalPrice;
        }


        public string getNewPayID()
        {
            string query = "SELECT MAX(MaHD)+1 AS MaHDMoi FROM dbo.HOADON";
            string id = "1";
            DataTable data = DataProvide.Instance.ExecuteQuery(query);
          
            foreach (DataRow row in data.Rows)
            {
                if (row["MaHDMoi"].ToString()=="")
                    break; 

                id = row["MaHDMoi"].ToString();
            }

            return id;

        }

        public void AddPayDetailByRoomID(List<string> strList)
        {
            string query = "EXEC dbo.sp_ThemChiTietHoaDonTheoPhong @MaPhong ";

            foreach (string item in strList)
            { 
                    DataProvide.Instance.ExecuteQuery(query, new object[] { int.Parse(item) });
            }

        }

        public void AddPay(string name, string date)
        {
            string query = "EXEC dbo.sp_ThemHoaDon @TenKH , @Ngay ";
            DataProvide.Instance.ExecuteQuery(query, new object[] { name, date });
        }


        public void UpdateStatusPay(int MaPhong)
        {
            string query = "EXEC dbo.sp_CapNhatTinhTrangThanhToan @MaPhong ";
            DataProvide.Instance.ExecuteQuery(query, new object[] { MaPhong });
        }

    }
}