using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class RoomStyleDTO
    {
        private int _statusCode;
        private string _statusName;
        public int StatusCode
        {
            get
            {
                return _statusCode;
            }

            set
            {
                _statusCode = value;
            }
        }

        public string StatusName
        {
            get
            {
                return _statusName;
            }

            set
            {
                _statusName = value;
            }
        }
        public RoomStyleDTO() { }
        public RoomStyleDTO(int _statusCode,string _statusName)
        {
            this._statusCode = _statusCode;
            this._statusName = _statusName;
        }
    }
}
