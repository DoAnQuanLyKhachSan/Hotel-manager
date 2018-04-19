﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class ReportDAO
    {
        private ReportDAO() { }
        private static ReportDAO instance;

        public static ReportDAO Instance
        {
            get
            {
                if (instance == null) instance = new ReportDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public void CreateReport(int _month, int _year)
        {

            string query = "EXEC dbo.sp_InsertIntoDoanhThu @month =" + _month.ToString() + " , @year =" + _year.ToString();
            DataProvide.Instance.ExecuteQuery(query);

        }
        public DataTable ViewReport(int _month, int _year)
        {
            string query = "SELECT dt.MaLoaiPhong,lp.TenLoaiPhong AS[Tên loại phòng], dt.DoanhThu, dt.TyLe FROM dbo.DOANHTHU dt JOIN dbo.LOAI_PHONG lp ON lp.MaLoaiPhong = dt.MaLoaiPhong WHERE dt.Nam=" + _year.ToString() + " AND dt.Thang=" + _month.ToString();
            return DataProvide.Instance.ExecuteQuery(query);
        }

    }
}
