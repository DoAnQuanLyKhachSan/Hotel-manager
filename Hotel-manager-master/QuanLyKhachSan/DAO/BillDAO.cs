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

    }
}
