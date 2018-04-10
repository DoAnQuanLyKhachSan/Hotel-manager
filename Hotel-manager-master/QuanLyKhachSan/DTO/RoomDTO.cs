using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class RoomDTO
    {
        public RoomDTO() { }
        public int RoomCode
        {
            get
            {
                return _roomCode;
            }

            set
            {
                _roomCode = value;
            }
        }
        public string RoomName
        {
            get
            {
                return _roomName;
            }

            set
            {
                _roomName = value;
            }
        }
        public int RoomStyle
        {
            get
            {
                return _roomStyle;
            }

            set
            {
                _roomStyle = value;
            }
        }
        public string RoomNote
        {
            get
            {
                return _roomNote;
            }

            set
            {
                _roomNote = value;
            }
        }
        public int RoomStatus
        {
            get
            {
                return _roomStatus;
            }

            set
            {
                _roomStatus = value;
            }
        }

        private int _roomCode;
        private string _roomName;
        private int _roomStyle;
        private string _roomNote;
        private int _roomStatus;
        
        public RoomDTO(int _roomCode, string _roomName ,int _roomStyle, string _roomNote=null,int _roomStatus = 1)
        {
            this._roomCode = _roomCode;
            this._roomName = _roomName;
            this._roomStyle = _roomStyle;
            this._roomNote = _roomNote;
            this._roomStatus = _roomStatus;
        }
        public RoomDTO(DataRow row)
        {
            this._roomCode = (int)row["MaPhong"];
            this._roomName = row["TenPhong"].ToString();
            this._roomStyle = (int)row["MaLoaiPhong"];
            this._roomNote = row["GhiChu"].ToString();
            this._roomStatus = (int)row["TinhTrangPhong"];
        }
    }
}
