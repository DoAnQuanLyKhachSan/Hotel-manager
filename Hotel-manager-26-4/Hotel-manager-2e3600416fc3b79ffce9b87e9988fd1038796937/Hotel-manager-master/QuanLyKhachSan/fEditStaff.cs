using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fEditStaff : Form
    {
        StaffDTO _staff = new StaffDTO();
        fStaff _fStaff = new fStaff();
        public fEditStaff(fStaff f)
        {
            InitializeComponent();
            _fStaff = f;
            loadForm();
        }
        private int _staffCode = 0;
        private string _staffName = null;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadForm()
        {
            loadStaff();
            setCbxBacLuong();
            setCbxPhongBan();
            setCbxChucVu();
        }

        private void loadStaff()
        {
            dtgvEditStaff.DataSource = StaffDAO.Instance.loadStaff();
        }

        private void dtgvEditStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _staffName = dtgvEditStaff.CurrentRow.Cells[0].Value.ToString();
            _staffCode = StaffDAO.Instance.returnStaffCode(_staffName);
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

        private StaffDTO getInfor()
        {
            _staff.MaBacLuong = int.Parse(cbxBacLuong.Text.ToString());
            _staff.MaPhongBan = int.Parse(cbxPhongBan.SelectedValue.ToString());
            _staff.MaChucVu = int.Parse(cbxChucVu.SelectedValue.ToString());
            return _staff;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                getInfor();
                    //return data ( int ) < 0 is success    
                    if (StaffDAO.Instance.updateStaff(_staffCode,_staff.MaBacLuong,_staff.MaPhongBan,_staff.MaChucVu) < 0)
                    {
                        MessageBox.Show("Sửa nhân viên thành công");
                      _fStaff.loadStaff();
                    }
               
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                MessageBox.Show("Nhập thông tin cần sửa");

    }
        }
    }
}
  