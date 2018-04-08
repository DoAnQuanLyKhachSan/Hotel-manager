using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class AddRoom
    {
        private AddRoom() { }
        private static AddRoom instace;

        public static AddRoom Instace
        {
            get
            {
                if (instace == null) instace = new AddRoom();
                return instace;
            }

            private set
            {
                instace = value;
            }
        }
        //private DataTable ExecuteAddRoomQuery(string _codeRoom, string _styleRoom, string _price)
        //{
        //    string query = "INSERT INTO SINHVIEN (ID,TEN,TUOI,KHOAHOC,HOCPHI) VALUES (1, 'Hoang', 21, 'CNTT', 4.0);
        //    "
        //    return
        //}
    }
}
