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
    public partial class fPayInfo : Form
    {
        public fPayInfo()
        {
            InitializeComponent();

            SetPayTable(PayRoomTable, PayCusTable);

        }

        public class getInfo
        {
            static public string nameCus;
            static public string addressCus;
            static public int typePay;
            public static List<string> ListRoomPayed = new List<string>();
            public static List<string> ListCusPayed = new List<string>();
        }

        DataTable PayRoomTable = new DataTable();
        DataTable PayCusTable = new DataTable();
      

        public void SetPayTable(DataTable t1, DataTable t2)
        {
            t1.Columns.Add(new DataColumn("MaPhong", typeof(int)));
            t1.Columns.Add(new DataColumn("NgayBatDauThue", typeof(string)));
            t1.Columns.Add(new DataColumn("TinhTrangThanhToan", typeof(int)));

            t2.Columns.Add(new DataColumn("MaCTPT", typeof(int)));
            t2.Columns.Add(new DataColumn("TenKhachHang", typeof(string)));
            t2.Columns.Add(new DataColumn("MaPhong", typeof(int)));
            t2.Columns.Add(new DataColumn("NgayBatDauThue", typeof(string)));
        }


        private void cbPayType_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
     
                List<string> list = PayDAO.Instance.getPayData(int.Parse(cb.SelectedIndex.ToString()));
                cbData.DataSource = list;

            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(cbData.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn dữ liệu để thêm!"); return;
            }

            if (int.Parse(cbPayType.SelectedIndex.ToString()) == 1)
            {
                if (PayDAO.Instance.CompareString(cbData.SelectedValue.ToString(), getInfo.ListRoomPayed))
                {
                    MessageBox.Show("Mã phòng này đã được thêm rồi!"); return;
                }
                else
                {
                    List<PayDTO> listPay = PayDAO.Instance.getRoomPay(int.Parse(cbData.SelectedValue.ToString()));

                    PayDAO.Instance.ListRoomPayToTable(listPay, PayRoomTable);

                    dtgvPay.DataSource = PayRoomTable;
                    getInfo.ListRoomPayed.Add(cbData.SelectedValue.ToString());
                }
            }
            else
            {
                if (PayDAO.Instance.CompareString(cbData.SelectedValue.ToString(), getInfo.ListCusPayed))
                {
                    MessageBox.Show("Tên khách hàng này đã được thêm rồi!"); return;
                }

                else
                {
                    List<PayDTO> listPay = PayDAO.Instance.getCusPay(cbData.SelectedValue.ToString());

                    PayDAO.Instance.ListCusPayToTable(listPay, PayCusTable);

                    dtgvPay.DataSource = PayCusTable;
                    getInfo.ListCusPayed.Add(cbData.SelectedValue.ToString());
                }
            }
        }

        private void btPayDetail_Click(object sender, EventArgs e)
        {

            if (txtCusName.Text.Length == 0)
            {
                MessageBox.Show("Tên khách hàng không được để trống"); return;
            }
            if (dtgvPay.DataSource == null)
            {
                MessageBox.Show("Chưa thêm dữ liệu để xem thanh toán"); return;
            }



            getInfo.typePay = cbPayType.SelectedIndex;
            getInfo.nameCus = txtCusName.Text;
            getInfo.addressCus = txtAddress.Text.ToString();

            fPayDetail f = new fPayDetail();
            this.Hide();
            f.ShowDialog();

            PayCusTable = new DataTable();
            PayRoomTable = new DataTable();
            SetPayTable(PayRoomTable, PayCusTable);

            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
