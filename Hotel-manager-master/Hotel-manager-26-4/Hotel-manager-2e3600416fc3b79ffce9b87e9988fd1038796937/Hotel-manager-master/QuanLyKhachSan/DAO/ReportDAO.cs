using System;
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

            string query = "EXEC dbo.sp_AUTO_InsertInto_ChiTietBaoCaoDoanhThu @month =" + _month.ToString() + " , @year =" + _year.ToString();
            DataProvide.Instance.ExecuteQuery(query);

        }
        public DataTable ViewReport(int _month, int _year)
        {
            string query = "EXEC dbo.sp_XemBaoCaoThang @month =" + _month.ToString() + " , @year=" + _year.ToString();
            return DataProvide.Instance.ExecuteQuery(query);
        }

    }
}
