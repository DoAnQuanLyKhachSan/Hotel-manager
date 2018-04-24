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

        public fAccountManagement()
        {
            InitializeComponent();
        }
        private int Choose = 0;

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
            LoadUserGroup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Choose = 2;
            LoadDecentralication();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Choose = 3;
            LoadUsers();
        }

        private void dtgvAccountManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                                    if (AccountManagementDAO.Instance.CheckExitsGroupCode(int.Parse(row.Cells[0].Value.ToString())) == false)
                                    {
                                        AccountManagementDAO.Instance.insertGroupUser(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString());
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
                                        AccountManagementDAO.Instance.insertPhanQuyen(int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString()));
                                     
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
                                    if (AccountManagementDAO.Instance.CheckExitsUser(row.Cells["Tên đăng nhập"].Value.ToString()) == false)
                                    {
                                        AccountManagementDAO.Instance.insertUser(row.Cells["Tên đăng nhập"].Value.ToString(), row.Cells["Mật khẩu"].Value.ToString(), int.Parse(row.Cells["Mã nhóm"].Value.ToString()));
                                      
                                    }
                                }
                            }
                            break;
                        }

                    default:
                        break;
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex) { if (ex is SqlException) MessageBox.Show("Nhập sai dữ liệu"); }
        }
        private void button6_Click(object sender, EventArgs e)//button delete
        {
            try
            {
                switch (Choose)
                {
                    case 1:
                        {
                            int data = DataProvide.Instance.ExecuteNonQuery(AccountManagementDAO.Instance.deleteGroupUser(int.Parse(GroupCode)));
                            //return data(int) > 0 is success
                            if (data > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                                LoadUserGroup();
                            }
                            break;
                        }
                    case 2:
                        {
                            int data = DataProvide.Instance.ExecuteNonQuery(AccountManagementDAO.Instance.deletePhanQuyen(int.Parse(GroupCode),int.Parse(FunctionCode)));
                            //return data(int) > 0 is success
                            if (data > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                                LoadDecentralication();
                            }
                            break;
                        }
                    case 3:
                        {
                            int data = DataProvide.Instance.ExecuteNonQuery(AccountManagementDAO.Instance.deleteUser(userName));
                            //return data(int) > 0 is success
                            if (data > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                                LoadUsers();
                            }
                            break;
                        }
                    default: break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button7_Click(object sender, EventArgs e)
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
                                        AccountManagementDAO.Instance.UpdateGroupUser(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(),int.Parse(GroupCode));
                                        
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
                                        AccountManagementDAO.Instance.UpdatePhanQuyen(int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString()),int.Parse(GroupCode),int.Parse(FunctionCode));
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
                                    if (AccountManagementDAO.Instance.CheckExitsUserEdit(row.Cells["Tên đăng nhập"].Value.ToString(), row.Cells["Mật khẩu"].Value.ToString(),int.Parse(row.Cells["Mã nhóm"].Value.ToString())) == false)
                                    {
                                        AccountManagementDAO.Instance.UpdateUser(row.Cells["Tên đăng nhập"].Value.ToString(), row.Cells["Mật khẩu"].Value.ToString(), int.Parse(row.Cells["Mã nhóm"].Value.ToString()),userName);
                                        
                                    }
                                }
                            }
                            break;
                        }

                    default:
                        break;
                }
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex) { if (ex is SqlException)
                    MessageBox.Show("Sửa thất bại,nên sữa mỗi lần một dòng");
                switch (Choose)
                {
                    case 1: LoadUserGroup();
                        break;
                    case 2: LoadDecentralication();
                        break;
                    case 3: LoadUsers();
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
