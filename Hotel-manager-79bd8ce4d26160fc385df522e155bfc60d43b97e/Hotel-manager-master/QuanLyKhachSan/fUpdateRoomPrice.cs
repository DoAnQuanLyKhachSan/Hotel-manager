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
    public partial class fUpdateRoomPrice : Form
    {
        public fUpdateRoomPrice()
        {
            InitializeComponent();
            LoadListRoomTypeID();
        }

        void LoadListRoomTypeID()
        {
            List<int> listID = new List<int>();
            listID = ChangeRegulationDAO.Instance.getListRoomTypeCode();
            cbListRoomType.DataSource = listID;
        }

        private void cbListRoomType_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if(cb.SelectedValue != null)
            {
                txbRoomTypeName.Text = ChangeRegulationDAO.Instance.getRoomTypeName((int)(cb.SelectedValue));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _roomTypeID = (int)cbListRoomType.SelectedValue;
            double _roomTypePrice = double.Parse(txbPrice.Text);
 
            ChangeRegulationDAO.Instance.UpdatePrice(_roomTypeID, _roomTypePrice);
            MessageBox.Show("Cập nhật thành công !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
