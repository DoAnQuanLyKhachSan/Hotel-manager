using QuanLyKhachSan.DAO;
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
    public partial class fDeleteStaff : Form
    {
        fStaff _fstaff = new fStaff();
        public fDeleteStaff(fStaff f=null)
        {
            InitializeComponent();
            _fstaff = f;
            loadStaff();
        }
        private string _staffName = null;
        private int _staffCode = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadStaff()
        {
            dtgvDeleteStaff.DataSource = StaffDAO.Instance.loadStaff();
        }
        

        private void dtgvDeleteStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _staffName = dtgvDeleteStaff.CurrentRow.Cells[0].Value.ToString();
            _staffCode = StaffDAO.Instance.returnStaffCode(_staffName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data = DataProvide.Instance.ExecuteNonQuery(StaffDAO.Instance.deleteStaffDatabaseQuery(_staffCode));
                //return data(int) > 0 is success
                if (data > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    loadStaff();
                    _fstaff.loadStaff();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa nhân viên thất bại ");
            }
        }
    }
}
