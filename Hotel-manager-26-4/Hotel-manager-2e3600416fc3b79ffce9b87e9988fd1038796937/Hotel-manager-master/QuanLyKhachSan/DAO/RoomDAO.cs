using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class RoomDAO
    {
        private RoomDAO() { }
        public static int RoomWidth=80;
        public static int RoomHeigh=80;
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get
            {
                if (instance == null) instance = new RoomDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<RoomDTO> LoadRoomList()
        {
            List<RoomDTO> RoomList = new List<RoomDTO>();
            DataTable data = DataProvide.Instance.ExecuteQuery("Select * from dbo.Phong");
            foreach (DataRow item in data.Rows)
            {
                RoomDTO roomDTO = new RoomDTO(item);
                RoomList.Add(roomDTO);
            }
            return RoomList;
        }
        public List<RoomDTO> LoadRoomListByStyle(int style)
        {
            List<RoomDTO> RoomList = new List<RoomDTO>();
            DataTable data = DataProvide.Instance.ExecuteQuery("select * from PHONG where TinhTrangPhong=" + style.ToString());
            foreach (DataRow item in data.Rows)
            {
                RoomDTO roomDTO = new RoomDTO(item);
                RoomList.Add(roomDTO);
            }
            return RoomList;
        }
        public List<RoomDTO> LoadStatusRoomList()
        {
            List<RoomDTO> RoomList = new List<RoomDTO>();
            DataTable data = DataProvide.Instance.ExecuteQuery("Select * from dbo.Phong");
            foreach (DataRow item in data.Rows)
            {
                RoomDTO roomDTO = new RoomDTO(item);
                RoomList.Add(roomDTO);
            }
            return RoomList;
        }
        public DataTable ExecuteQuerySearchCodeRoom(string _str)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTinhTrang as 'Tình trạng' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TINH_TRANG_PHONG tt on tt.TinhTrangPhong = p.TinhTrangPhong where p.MaPhong = " + _str;
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public DataTable ExecuteQuerySearchStyleRoom(string _str)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTinhTrang as 'Tình trạng' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TINH_TRANG_PHONG tt on tt.Ma = p.TinhTrangPhong where p.MaLoaiPhong = " + _str;
            return DataProvide.Instance.ExecuteQuery(query);
        }

        public DataTable ExecuteQuerySearchStatusRoom(string _str)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTinhTrang as 'Tình trạng' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TINH_TRANG_PHONG tt on tt.MaTinhTrang = p.TinhTrangPhong where p.TinhTrangPhong = " + _str;
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public string codeRoomSearchListQuery() { return  "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTinhTrang as 'Tình trạng' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TINH_TRANG_PHONG tt on tt.MaTinhTrang = p.TinhTrangPhong where p.MaPhong = "; }
        public string styleRoomSearch() { return "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTinhTrang as 'Tình trạng' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TINH_TRANG_PHONG tt on tt.MaTinhTrang = p.TinhTrangPhong where p.MaLoaiPhong = "; }
        public string statusRoomSearch() { return "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTinhTrang as 'Tình trạng' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TINH_TRANG_PHONG tt on tt.MaTinhTrang = p.TinhTrangPhong where p.TinhTrangPhong = ";}
        public string ExecuteLoadInforRoomQuery() { return "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTinhTrang as 'Tình trạng' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong=p.MaLoaiPhong inner join TINH_TRANG_PHONG tt on tt.MaTinhTrang=p.TinhTrangPhong"; }
        public string setDataStyleRoomQuery() { return "select MaLoaiPhong,TenLoaiPhong From dbo.LOAI_PHONG"; }
        public string setDataRoomStatusQuery() { return "select MaTinhTrang,TenTinhTrang from dbo.TINH_TRANG_PHONG"; }
        public string setDataPriceRoomQuery() { return "select DonGia from dbo.LOAI_PHONG"; }
        public string cbxstyleRoom_SelectIndexQuery() { return "select DonGia from dbo.LOAI_PHONG where MaLoaiPhong = ";}
        public string addRoomDatabaseQuery() { /*use PROC in SQL SEVER */return "EXEC dbo.AddRoomToDataBase @RoomCode , @RoomName , @RoomStyle , @RoomNote "; }

        public int deleteRoomDatabaseQuery(int maPhong) {
            string query = "exec XoaPhong @MaPhong ";
            int rs = DataProvide.Instance.ExecuteNonQuery(query, new object[] { maPhong });
            return rs;
        }

        public string UpdateRoomDatabaseQuery() { /*use PROC in SQL SEVER */return "EXEC dbo.UpdateRoomToDataBase @RoomCodeNew , @RoomName , @RoomStyle , @RoomNote , @RoomStatus , @RoomCodeOld "; }

        public string setComboBoxformality() { return "select MaHinhThucThue,TenHinhThucThue from dbo.HINHTHUCTHUE"; }
        public int ReturnRoomCode(string roomName)
        {
            string query = "select MaPhong from Phong where TenPhong = N'" + roomName + "'";
            string data = DataProvide.Instance.ExecuteReader(query);
            return int.Parse(data);
        }

       
        public int CreateTenancyCard(int getCodeRoom,int Formality, string getBeginDay,int guestNum)
        {
            string createTenancyCardQuery = "EXEC dbo.CreateTenancyCard @RoomCode , @FormalityCode , @BeginDay , @GuestNum ";
            int rs = DataProvide.Instance.ExecuteNonQuery(createTenancyCardQuery, new object[] { getCodeRoom, Formality,getBeginDay,guestNum });
            return rs;
        }

        public int ReturnTenancyCardCode(int getCodeRoom)
        {
            string query = "select MaPT from PHIEUTHUEPHONG WHERE MaPhong = "+getCodeRoom+" AND TinhTrangThanhToan = 0";
            string data = DataProvide.Instance.ExecuteReader(query);
            return int.Parse(data);
        }

        public  void CreateTenancyCardDetail(CustomerDTO [] _ListCustomer,int getCodeRoom,string getBeginDay)
        {
            foreach(CustomerDTO _customer in _ListCustomer)
            {
                if (_customer != null)
                {
                    string createTenancyCardDetailQuery = "EXEC dbo.CreateTenancyCardDetail @TenancyCardCode , @CustomerName , @CustomerStyleCode , @CustomerCMND , @CustomerAddress ";
                     DataProvide.Instance.ExecuteNonQuery(createTenancyCardDetailQuery, new object[] { ReturnTenancyCardCode(getCodeRoom), _customer.CustomerName, _customer.CustomerStyle, _customer.CustomerCMND, _customer.CustomerAddress });
                } 
            }
        }
       

        public bool checkStatusRoomisRent(int getRoomCode)
        {
            string query = "select MaPhong from dbo.PHONG where TinhTrangPhong =1 AND MaPhong ="+getRoomCode;
            string rs = DataProvide.Instance.ExecuteReader(query);
            if (rs != null) return true;
            return false;
        }
        public bool checkStatusRoomisRenting(int getRoomCode)
        {
            string query = "select MaPhong from dbo.PHONG where TinhTrangPhong =2 AND MaPhong =" + getRoomCode;
            string rs = DataProvide.Instance.ExecuteReader(query);
            if (rs != null) return true;
            return false;
        }

    }
}
