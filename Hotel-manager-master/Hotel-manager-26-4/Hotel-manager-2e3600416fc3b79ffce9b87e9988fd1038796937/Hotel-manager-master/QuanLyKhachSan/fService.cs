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
    public partial class fService : Form
    {
        public fService()
        {
            InitializeComponent();
            Load_fService();

        }

        private int getRentID()
        {
            return int.Parse(cbListRentID.SelectedValue.ToString());
        }

        private int getServiceID()
        {
            return ServiceDAO.Instance.getServiceID(cbListService.SelectedValue.ToString());
        }

        private string getCusName()
        {
            return cbListNameCus.SelectedValue.ToString();
        }

        private string getDateTimeUseService()
        {
            return dtpUseService.Value.ToString("MM/dd/yyyy HH:mm:ss");
        }
        private int getCount()
        {
            return int.Parse(txbCount.Text);
        }

        public void Load_fService()
        {
            cbListRentID.DataSource = PayDAO.Instance.LoadListPayRentID();
     
            cbListService.DataSource = ServiceDAO.Instance.getListServiceName();

        }

        private void cbListRentID_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue != null)
            {

                cbListNameCus.DataSource = ServiceDAO.Instance.getListCusName(int.Parse(cb.SelectedValue.ToString()));

                dtgvHistoryService.DataSource =  ServiceDAO.Instance.Load_HistoryService(int.Parse(cb.SelectedValue.ToString()));
            }
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceDAO.Instance.CreateDetailUseService(getRentID(), getServiceID(), getCusName(), getDateTimeUseService(), getCount());
                dtgvHistoryService.DataSource = ServiceDAO.Instance.Load_HistoryService(getRentID());
                MessageBox.Show("Thuê Dịch Vụ Thành Công!");
            }
            catch
            {
                MessageBox.Show("Cần điền đầy đủ thông tin và nhập đúng định dạng!");
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
