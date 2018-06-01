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
    public partial class fPayInfo : Form
    {
        public fPayInfo()
        {
            InitializeComponent();
            Load_fPayInfo();
            SetTablePay(TablePay);
        }


        public class getInfo
        {
            static public string nameCus;
            static public string addressCus;
            static public List<string> ListRentIDPay = new List<string>();
        }

        DataTable TablePay = new DataTable();

        public void Load_fPayInfo()
        {
            cbListRentID.Text = string.Empty;
            cbListRentID.DataSource = PayDAO.Instance.LoadListPayRentID();
            txbAddress.Text = string.Empty;
            txbCusName.Text = string.Empty;
            txbPayID.Text = PayDAO.Instance.GetNewPayID().ToString();
        }

        public void SetTablePay(DataTable t1)
        {
            t1.Columns.Add(new DataColumn("Mã Phiếu Thuê", typeof(int)));
            t1.Columns.Add(new DataColumn("Mã Phòng", typeof(int)));
            t1.Columns.Add(new DataColumn("Ngày Giờ Bắt Đầu Thuê", typeof(string)));
            t1.Columns.Add(new DataColumn("Tình Trạng Thanh Toán", typeof(int)));
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbListRentID.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn Mã phiếu thuê để thanh toán!"); return;

            }

            DataTable data = PayDAO.Instance.RentPay(cbListRentID.SelectedValue.ToString());
            DataRow row = data.Rows[0];

            if (getInfo.ListRentIDPay.Contains(row["MaPT"].ToString()))
            {
                MessageBox.Show("Mã phiếu thuê này đã được thêm!"); return;
            }
            else
            {
                TablePay.Rows.Add(row["MaPT"], row["MaPhong"], row["NgayGioBatDauThue"], row["TinhTrangThanhToan"]);
                getInfo.ListRentIDPay.Add(cbListRentID.SelectedValue.ToString());
            }

            dtgvPay.DataSource = TablePay;
        }

        private void btCreatePay_Click(object sender, EventArgs e)
        {
            if (txbCusName.Text.Length == 0 || txbAddress.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập tên người thanh toán hoặc địa chỉ!"); return;
            }

            if (dtgvPay.DataSource == null)
            {
                MessageBox.Show("Chưa thêm dữ liệu để thanh toán"); return;
            }

            PayDAO.Instance.AddPay(txbCusName.Text, dtpPay.Value.ToString("MM/dd/yyyy HH:mm:ss"));

            PayDAO.Instance.AddPayDetailByRentID(getInfo.ListRentIDPay);

            getInfo.nameCus = txbCusName.Text;
            getInfo.addressCus = txbAddress.Text;
            TablePay = new DataTable();
            SetTablePay(TablePay);

            fPayDetail f = new fPayDetail();
            this.Hide();
            dtgvPay.DataSource = null;
            f.ShowDialog();
            Load_fPayInfo();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fPayInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            getInfo.ListRentIDPay = new List<string>();
        }
    }
}
