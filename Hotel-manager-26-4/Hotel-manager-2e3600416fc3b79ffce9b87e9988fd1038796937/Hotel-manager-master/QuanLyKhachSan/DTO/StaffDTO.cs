using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class StaffDTO
    {
        private string _hoTen;
        private DateTime _ntns;
        private DateTime _ngayBatDauVaoLam;
        private int _soHD;
        private int _maBacLuong;
        private int _maPhongBan;
        private int _maChucVu;

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public DateTime Ntns
        {
            get
            {
                return _ntns;
            }

            set
            {
                _ntns = value;
            }
        }

        public DateTime NgayBatDauVaoLam
        {
            get
            {
                return _ngayBatDauVaoLam;
            }

            set
            {
                _ngayBatDauVaoLam = value;
            }
        }

        public int MaBacLuong
        {
            get
            {
                return _maBacLuong;
            }

            set
            {
                _maBacLuong = value;
            }
        }

        public int MaPhongBan
        {
            get
            {
                return _maPhongBan;
            }

            set
            {
                _maPhongBan = value;
            }
        }

        public int MaChucVu
        {
            get
            {
                return _maChucVu;
            }

            set
            {
                _maChucVu = value;
            }
        }

        public int SoHD
        {
            get
            {
                return _soHD;
            }

            set
            {
                _soHD = value;
            }
        }

        public StaffDTO()
        {

        }
        public StaffDTO(string hoTen,DateTime ntns,DateTime ngayBatDauVaoLam,int soHD,int maBacLuong,int maPhongBan,int maChucVu)
        {
            this._hoTen = hoTen;
            this._ntns = ntns;
            this._ngayBatDauVaoLam = ngayBatDauVaoLam;
            this._soHD = soHD;
            this._maBacLuong = maBacLuong;
            this._maPhongBan = maPhongBan;
            this._maChucVu = maChucVu;
        }
    }
}
