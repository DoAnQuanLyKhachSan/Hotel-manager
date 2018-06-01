using QuanLyKhachSan.DAO;
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
    public partial class fAccountManagement : Form
    {
        private string GroupCode = null;    // GroupCode và FuctionCode kiểu string vì hạn chế lỗi click vào ô không có dữ liệu của hàm dtgvAccountManagement_CellClick 
        private string FunctionCode = null;
        private string userName = null;
        private string tenNhomMoi = null;
        private bool isMaNhom = false;
        private bool isTenNhom = false;
        private string maNhomMoi = null;
        private string maNhomCu = null;
        private string tenNhomCu = null;
        public fAccountManagement()
        {
            InitializeComponent();
            LoadDSCN();
            LoadListUserGroup();
        }
        private int Choose = 0;

        private void LoadDSCN()
        {
            dtgvDSCN.DataSource = AccountManagementDAO.Instance.getListChucNang();
        }
        private void LoadListUserGroup()
        {
            dtgvDSMN.DataSource = AccountManagementDAO.Instance.getUserGroupFromDataBase();
        }

        private void LoadUserGroup()
        {
            dtgvAccountManagement.DataSource = AccountManagementDAO.Instance.getUserGroupFromDataBase();
        }
        private void LoadDecentralication()
        {
            dtgvAccountManagement.DataSource = AccountManagementDAO.Instance.getDecentralizationFromDataBase();
        }
        private void LoadUsers()
        {
            dtgvAccountManagement.DataSource = AccountManagementDAO.Instance.getUsersFromDataBase();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Choose = 1;
            lbAccountManagerment.Text = "Danh sách nhóm người dùng : ";
            LoadUserGroup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Choose = 2;
            lbAccountManagerment.Text = "Danh sách phân quyền người dùng : ";
            LoadDecentralication();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Choose = 3;
            lbAccountManagerment.Text = "Danh sách người dùng : ";
            LoadUsers();
        }


        private void dtgvAccountManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbCanhBao.ResetText();

            switch (Choose)
            {
                case 1:
                    {
                        GroupCode = dtgvAccountManagement.CurrentRow.Cells["Mã nhóm"].Value.ToString();
                        break;
                    }
                case 2:
                    {
                        FunctionCode = dtgvAccountManagement.CurrentRow.Cells["Mã chức năng"].Value.ToString();
                        GroupCode = dtgvAccountManagement.CurrentRow.Cells["Mã nhóm"].Value.ToString();
                        break;
                    }
                case 3:
                    {
                        userName = dtgvAccountManagement.CurrentRow.Cells["Tên đăng nhập"].Value.ToString();
                        break;
                    }
            }

        }

        private void button5_Click(object sender, EventArgs e)//button add
        {
           
                switch (Choose)
                {
                    case 1:
                        {
                            foreach (DataGridViewRow row in dtgvAccountManagement.Rows)
                            {
                                if (row.Cells[0].Value != null)
                                {
                                    try
                                    {
                                        if (AccountManagementDAO.Instance.CheckExitsGroupCode(int.Parse(row.Cells[0].Value.ToString())) == false)
                                        {

                                            int data = AccountManagementDAO.Instance.insertGroupUser(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString());
                                            if (data > 0)
                                            {
                                                lbCanhBao.Text = "Thêm thành công !!!";
                                                LoadListUserGroup();
                                            LoadUserGroup();
                                            }
                                            else
                                            {
                                                lbCanhBao.Text = "Thêm thất bại !!!";
                                            }
                                        }
                                    }
                                    catch(Exception ex)
                                    {

                                        lbCanhBao.Text = "Nhập thiếu dữ liệu";
                                    }
                                }
                            }
                            break;
                        }



                    case 2:
                        {
                            foreach (DataGridViewRow row in dtgvAccountManagement.Rows)
                            {
                                if (row.Cells[0].Value != null)
                                {
                                    try
                                    {
                                        if (AccountManagementDAO.Instance.CheckExitsPhanQuyen(int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString())) == false)
                                        {
                                            int data = AccountManagementDAO.Instance.insertPhanQuyen(int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString()));
                                            if (data > 0)
                                            {
                                                lbCanhBao.Text = "Thêm thành công";
                                                LoadDecentralication();
                                            }
                                            else
                                            {
                                                lbCanhBao.Text = "Thêm thất bại !!!";
                                            }
                                        }
                                    }

                                    catch
                                    {
                                        lbCanhBao.Text = "Nhập thiếu dữ liệu";
                                    }
                                }
                            }

                            break;
                        }


                    case 3:
                        {
                            foreach (DataGridViewRow row in dtgvAccountManagement.Rows)
                            {
                            if (row.Cells[0].Value != null)
                            {
                                try {
                                    if (AccountManagementDAO.Instance.CheckExitsUser(row.Cells["Tên đăng nhập"].Value.ToString()) == false)
                                    {
                                        int data = AccountManagementDAO.Instance.insertUser(row.Cells["Tên đăng nhập"].Value.ToString(), row.Cells["Mật khẩu"].Value.ToString(), int.Parse(row.Cells["Mã nhóm"].Value.ToString()));
                                        if (data > 0)
                                        {
                                            lbCanhBao.Text = "Thêm thành công";
                                            LoadUsers();
                                        }
                                    }
                                    else
                                    {
                                        lbCanhBao.Text = "Thêm thất bại !!!";
                                    }
                                }
                                catch (Exception ex)
                                {
                                    if (ex is SqlException) lbCanhBao.Text = "Không tồn tại mã nhóm hoặc nhập thiếu";
                                }
                            }
                            }
                            break;
                        }

                    default:
                        break;
                }
          
    }
    private void button6_Click(object sender, EventArgs e)//button delete
    {
        try
        {
            switch (Choose)
            {
                case 1:
                    {
                        int data = DataProvide.Instance.ExecuteNonQuery(AccountManagementDAO.Instance.deletePhanQuyenVoiMaNhom(int.Parse(GroupCode)));
                        data += DataProvide.Instance.ExecuteNonQuery(AccountManagementDAO.Instance.deleteUserVoiMaNhom(int.Parse(GroupCode)));
                        data += DataProvide.Instance.ExecuteNonQuery(AccountManagementDAO.Instance.deleteGroupUser(int.Parse(GroupCode)));
                        //return data(int) > 0 is success
                        if (data > 0)
                        {
                            lbCanhBao.Text = "Xóa thành công";
                            LoadUserGroup();
                                LoadListUserGroup();
                        }
                        else
                        {
                            lbCanhBao.Text = "Xóa thất bại";
                        }
                        break;
                    }
                case 2:
                    {
                        int data = DataProvide.Instance.ExecuteNonQuery(AccountManagementDAO.Instance.deletePhanQuyen(int.Parse(GroupCode), int.Parse(FunctionCode)));
                        //return data(int) > 0 is success
                        if (data > 0)
                        {
                            lbCanhBao.Text = "Xóa thành công";
                            LoadDecentralication();
                        }
                        else
                        {
                            lbCanhBao.Text = "Xóa thất bại";
                        }
                        break;
                    }
                case 3:
                    {
                        int data = DataProvide.Instance.ExecuteNonQuery(AccountManagementDAO.Instance.deleteUser(userName));
                        //return data(int) > 0 is success
                        if (data > 0)
                        {
                            lbCanhBao.Text = "Xóa thành công";
                            LoadUsers();
                        }
                        else
                        {
                            lbCanhBao.Text = "Xóa thất bại";
                        }
                        break;
                    }
                default: break;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
    private void button7_Click(object sender, EventArgs e)//edit
    {
        try
        {
            switch (Choose)
            {
                case 1:
                    {
                        foreach (DataGridViewRow row in dtgvAccountManagement.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                if (AccountManagementDAO.Instance.CheckExitsGroupEdit(int.Parse(row.Cells["Mã nhóm"].Value.ToString()), row.Cells["Tên nhóm"].Value.ToString()) == false)
                                {
                                    int data = 0;
                                    if (isMaNhom == false)
                                    {
                                        if (isTenNhom == true)
                                        {
                                            data = AccountManagementDAO.Instance.UpdateGroupUser(int.Parse(GroupCode), null, row.Cells["Tên nhóm"].Value.ToString());
                                        }

                                    }
                                    else
                                    {
                                        if (isTenNhom == true) data = AccountManagementDAO.Instance.UpdateGroupUser(int.Parse(maNhomCu), maNhomMoi, row.Cells["Tên nhóm"].Value.ToString());
                                        else
                                        {
                                            data = AccountManagementDAO.Instance.UpdateGroupUser(int.Parse(GroupCode), maNhomMoi);
                                        }
                                    }


                                    if (data > 0)
                                    {
                                        lbCanhBao.Text = "Sửa thành công";
                                        LoadListUserGroup();
                                        LoadUserGroup();
                                        isTenNhom = false;
                                        isMaNhom = false;
                                    }
                                    else
                                    {
                                        lbCanhBao.Text = "Sửa thất bại";
                                    }

                                }
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        foreach (DataGridViewRow row in dtgvAccountManagement.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                if (AccountManagementDAO.Instance.CheckExitsPhanQuyen(int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString())) == false)
                                {
                                    int data = AccountManagementDAO.Instance.UpdatePhanQuyen(int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString()), int.Parse(GroupCode), int.Parse(FunctionCode));
                                    if (data > 0)
                                    {
                                        lbCanhBao.Text = "Sửa thành công";
                                        LoadDecentralication();
                                    }
                                    else
                                    {
                                        lbCanhBao.Text = "Sửa thất bại";
                                    }
                                }
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        foreach (DataGridViewRow row in dtgvAccountManagement.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                if (AccountManagementDAO.Instance.CheckExitsUserEdit(row.Cells["Tên đăng nhập"].Value.ToString(), row.Cells["Mật khẩu"].Value.ToString(), int.Parse(row.Cells["Mã nhóm"].Value.ToString())) == false)
                                {
                                    int data = AccountManagementDAO.Instance.UpdateUser(row.Cells["Tên đăng nhập"].Value.ToString(), row.Cells["Mật khẩu"].Value.ToString(), int.Parse(row.Cells["Mã nhóm"].Value.ToString()), userName);
                                    if (data > 0)
                                    {
                                        lbCanhBao.Text = "Sửa thành công";
                                        LoadUsers();
                                    }
                                    else
                                    {
                                        lbCanhBao.Text = "Sửa thất bại";
                                    }
                                }
                            }
                        }
                        break;
                    }

                default:
                    break;
            }
        }
        catch (Exception ex)
        {
            if (ex is SqlException)
                MessageBox.Show("Sửa thất bại,nên sữa mỗi lần một dòng");

        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dtgvAccountManagement_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        if (e.Exception is FormatException) MessageBox.Show("Lỗi cú pháp");
    }


    private void dtgvAccountManagement_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (dtgvAccountManagement.Columns[e.ColumnIndex].Name == "Mã nhóm")
        {
            isMaNhom = true;
            maNhomMoi = dtgvAccountManagement[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
        if (dtgvAccountManagement.Columns[e.ColumnIndex].Name == "Tên nhóm")
        {
            isTenNhom = true;
            tenNhomMoi = dtgvAccountManagement[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
    }

    private void dtgvAccountManagement_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {

        if (dtgvAccountManagement.Columns[e.ColumnIndex].Name == "Mã nhóm")
        {

            maNhomCu = dtgvAccountManagement[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
        if (dtgvAccountManagement.Columns[e.ColumnIndex].Name == "Tên nhóm")
        {

            tenNhomCu = dtgvAccountManagement[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
    }
}
}
