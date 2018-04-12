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
    public partial class fAddRoomType : Form
    {
        public fAddRoomType()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ChangeRegulationDAO.Instance.IsNumber(txbID.Text.ToString()) == false || txbID.Text.Length==0)
            {
                MessageBox.Show("Mã phòng phải là kiểu Số nguyên và không được để trống, Nhập lại!");
                txbID.Text = string.Empty;
                return;
            }

            if (ChangeRegulationDAO.Instance.IsNumber(txbPrice.Text) == false || txbPrice.Text.Length == 0)
            {
                MessageBox.Show("Đơn giá phải là kiểu Số và không được để trống, kiểm tra lại!");
                return;
            }

            int _ID = int.Parse(txbID.Text);
            string _Name = txbName.Text.ToString();
            double _Price = double.Parse(txbPrice.Text);

            if (ChangeRegulationDAO.Instance.getListRoomTypeCode().Contains(_ID))
                {
                    MessageBox.Show("Mã phòng bạn thêm mới đã tồn tại, Mời nhập lại!");
                }

            else
            {
                ChangeRegulationDAO.Instance.AddRoomType(_ID, _Name, _Price);
                MessageBox.Show("Thêm mới thành công!");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbID.Text = string.Empty;
            txbName.Text = string.Empty;
            txbPrice.Text = string.Empty;

        }
    }
}
