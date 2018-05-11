using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fAddStaff : Form
    {
        StaffDTO staff = new StaffDTO();
        fStaff fstaff = new fStaff();
        public fAddStaff(fStaff f)
        {
            InitializeComponent();
            loadValue();
            fstaff = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadValue()
        {
            setCbxBacLuong();
            setCbxPhongBan();
            setCbxChucVu();
            loadSOHD();
        }
        private void setCbxBacLuong()
        {
            cbxBacLuong.DisplayMember = "MaBacLuong";
            cbxBacLuong.ValueMember = "MaBacLuong";
            cbxBacLuong.DataSource = StaffDAO.Instance.traVeMaBacLuong();
        }

        private void setCbxPhongBan()
        {
            cbxPhongBan.DisplayMember = "TenPhongBan";
            cbxPhongBan.ValueMember = "MaPhongBan";
            cbxPhongBan.DataSource = StaffDAO.Instance.traVeTenVaMaPhongBan();
        }
        private void setCbxChucVu()
        {
            cbxChucVu.DisplayMember = "TenChucVu";
            cbxChucVu.ValueMember = "MaChucVu";
            cbxChucVu.DataSource = StaffDAO.Instance.traVeTenVaMaChucVu();
        }

        private void loadSOHD()
        {
            
            
            txbSoHopDong.Text = (StaffDAO.Instance.soHDLonNhat() + 1).ToString();
        }


        StaffDTO getStaff()
        {
            staff.HoTen = txbHoTen.Text.ToString();
            staff.Ntns = dtpkNTNS.Value.Date.ToLocalTime();
            staff.NgayBatDauVaoLam = dtpkNgayKiHD.Value.Date.ToLocalTime();
            staff.SoHD = int.Parse(txbSoHopDong.Text.ToString());
            staff.MaBacLuong = int.Parse(cbxBacLuong.Text.ToString());
            staff.MaPhongBan = int.Parse(cbxPhongBan.SelectedValue.ToString());
            staff.MaChucVu = int.Parse(cbxChucVu.SelectedValue.ToString());
            return staff;
        }

        private void button1_Click(object sender, EventArgs e)//button add Staff
        {
            getStaff();
            try
            {
                int data = StaffDAO.Instance.AddStaffToDataBase(staff.HoTen,staff.Ntns,staff.NgayBatDauVaoLam,staff.SoHD,staff.MaBacLuong,staff.MaPhongBan,staff.MaChucVu);
                MessageBox.Show("Thêm thành công");
                fstaff.loadStaff();

            }
            catch (Exception) { MessageBox.Show("Thêm thất bại"); }
      }
    }
}
