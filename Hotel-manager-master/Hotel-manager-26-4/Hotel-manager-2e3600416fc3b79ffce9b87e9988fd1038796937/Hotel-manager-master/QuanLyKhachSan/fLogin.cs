using QuanLyKhachSan;
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
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class fLogin : Form
    {
        public UserDTO user = new UserDTO();
        public fLogin()
        {
            InitializeComponent();
            
        }

        public UserDTO getUser()
        {
            user.UserName = txbUser.Text.ToString();
            user.UserPass = txbPass.Text.ToString();
            return user;
        }
      
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) //button Login
        {
            //SqlConnection conn =new SqlConnection (@"Data Source=DESKTOP-OAVL1J3;Initial Catalog=HOTEL_MANAGER;Integrated Security=True");
            if (LoginDAO.Instance.Login(getUser().UserName,getUser().UserPass) == true)
            {
                //try
                //{
                    //conn.Open();
                    this.Hide();
                    MainMenu main = new MainMenu(this);
                    main.ShowDialog();
                    txbUser.ResetText();
                    txbPass.ResetText();
                    this.txbUser.Select();
                    this.Show();
                //}
                //catch(Exception ex)
                //{
                //    MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu");
                //}
            }
            else
            {
                if (LoginDAO.Instance.checkUserName(getUser().UserName) == false) MessageBox.Show("Sai tên đăng nhập");
                else MessageBox.Show("Sai mật khẩu");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
