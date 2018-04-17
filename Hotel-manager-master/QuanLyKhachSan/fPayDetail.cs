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
    public partial class fPayDetail : Form
    {
        public fPayDetail()
        {
            InitializeComponent();

            setTablePayDetail(TablePayDetail);

            LoadPayDetailInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            fPayInfo.getInfo.ListCusPayed = new List<string>();
            fPayInfo.getInfo.ListRoomPayed = new List<string>();
            this.Close();
        }

        DataTable TablePayDetail = new DataTable();

        public void setTablePayDetail(DataTable data)
        {
            data.Columns.Add(new DataColumn("MaPhong", typeof(int)));
            data.Columns.Add(new DataColumn("TenKhachHang", typeof(string)));
            data.Columns.Add(new DataColumn("SoNgayThue", typeof(int)));
            data.Columns.Add(new DataColumn("DonGia", typeof(string)));
            data.Columns.Add(new DataColumn("TongTienPhong", typeof(string)));
        }

        public void LoadPayDetailInfo()
        {
            txbReadNameCus.Text = fPayInfo.getInfo.nameCus;
            txbReadAddress.Text = fPayInfo.getInfo.addressCus;
            double totalPrice = 0;
            if (fPayInfo.getInfo.typePay == 1)
            {
                foreach (string item in fPayInfo.getInfo.ListRoomPayed)
                {
                    List<PayDTO> list = PayDAO.Instance.getListPayDetailByRoom(int.Parse(item));

                    PayDAO.Instance.ListPayDetailToTable(list, TablePayDetail);

                    totalPrice += PayDAO.Instance.getTotalPrice(item);
                }
            }
            else
            {
                foreach (string item in fPayInfo.getInfo.ListCusPayed)
                {
                    List<PayDTO> list = PayDAO.Instance.getListPayDetailByCusName(item.ToString());

                    PayDAO.Instance.ListPayDetailToTable(list, TablePayDetail);

                    foreach (PayDTO roomID in list)
                    {
                        totalPrice += PayDAO.Instance.getTotalPrice(roomID.RoomID.ToString());
                    }
                }
            }

            dtgvPayDetail.DataSource = TablePayDetail;

            txbTotalPrice.Text = totalPrice.ToString() + "   đ";
        }

    }
}
