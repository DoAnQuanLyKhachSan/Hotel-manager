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
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void chReport_Click(object sender, EventArgs e)
        {
           
        }

        private void fReport_Activated(object sender, EventArgs e)
        {
            chReport.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataRoomStatusQuery());
        }
    }
}
