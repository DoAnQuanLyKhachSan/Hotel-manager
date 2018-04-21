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
            
            if (LoginDAO.Instance.Login(getUser().UserName,getUser().UserPass) == true)
            {
                this.Hide();
                MainMenu main = new MainMenu(this);
                main.ShowDialog();
                txbUser.ResetText();
                txbPass.ResetText();
                this.txbUser.Select();
                this.Show();
            }
            else
            {
                if (LoginDAO.Instance.checkUserName(getUser().UserName) == false) MessageBox.Show("Sai tên đăng nhập");
                else MessageBox.Show("Sai mật khẩu");
            }
        }
        
    }
}
