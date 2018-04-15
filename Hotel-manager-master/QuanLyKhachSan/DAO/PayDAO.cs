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

        public List<string> getAddressCus(string _name)
        {
            List<string> addrList = new List<string>();
            string query = "EXEC dbo.sp_LayDiaChi @Name ";
            DataTable data = DataProvide.Instance.ExecuteQuery(query, new object[] { _name });
            if (data.Rows.Count > 0)
                foreach (DataRow item in data.Rows)
                {
                    addrList.Add(item["DiaChi"].ToString());
                }

            else
                addrList = null;

            return addrList;
        }

        public DataTable LoadPayInfo(string _name, string _diachi)
        {
            string query = "EXEC dbo.sp_ChiTietThanhToan @TenKH , @DiaChi";
            return DataProvide.Instance.ExecuteQuery(query, new object[] { _name, _diachi });
        }

        public float getTotalPrice(string _name, string _diachi)
        {
            float _Price = new float();
            string query = "EXEC dbo.sp_getTongTien @TenKH , @DiaChi ";

            DataTable data = DataProvide.Instance.ExecuteQuery(query, new object[] {_name, _diachi });

            foreach (DataRow item in data.Rows)
            {
                _Price = float.Parse(item["TongTien"].ToString());
                break;
            }
            return _Price;
        }

    }
}
