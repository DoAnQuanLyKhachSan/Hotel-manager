using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
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
    public partial class fRent : Form
    {
        CustomerDTO[] _customer = new CustomerDTO[5];
        fRoom f = new fRoom();
        MainMenu m = new MainMenu();
        public fRent(fRoom room, string roomname,MainMenu mainMenu)
        {
            InitializeComponent();
            m = mainMenu;
            this.txbRoomName.Text = roomname;
            //f = room;
        }

        public fRent(fRoom room)
        {
            InitializeComponent();
            f = room;
        }

        private int getRoomCode()
        {
            return RoomDAO.Instance.ReturnRoomCode(txbRoomName.Text.ToString());
        }

        private DateTime getBeginDay()
        {
            return dtBeginRent.Value.Date.ToLocalTime();
        }

        public void getInforCustomer()
        {
            int i = 0;

            foreach (DataGridViewRow row in dtgvInputCustomes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    _customer[i] = new CustomerDTO();
                    _customer[i].CustomerName = row.Cells[0].Value.ToString();
                    _customer[i].CustomerStyle = RoomDAO.Instance.ReturnCustomerCode(row.Cells[1].Value.ToString());
                    _customer[i].CustomerCMND = int.Parse(row.Cells[2].Value.ToString());
                    _customer[i].CustomerAddress = row.Cells[3].Value.ToString();
                    i++;
                }
            }
        }

        void LoadListRoomAndCloseForm()
        {
            f.LoadRoomList();
            this.Close();
        }


        
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoomDAO.Instance.checkStatusRoomisRent(getRoomCode()) == true)  // nếu phòng có thể cho thuê thì trả về true
                {
                    getInforCustomer();// tạo một danh sách đối tượng khách hàng thuê phòng
                    RoomDAO.Instance.CreateTenancyCard(getRoomCode(), getBeginDay());//tao phieu thue phong
                    RoomDAO.Instance.CreateTenancyCardDetail(_customer, getRoomCode(), getBeginDay());//tao chitiet-thuephong
                    RoomDAO.Instance.updateStatusRoom(getRoomCode()); //update status Room 
                    MessageBox.Show("Tạo phiếu thuê phòng thành công");
                    LoadListRoomAndCloseForm();
                    m.ReLoadRoomStatus();
                }
                else   // phòng đang sửa chữa hoặc đang cho thuê
                {
                    if (RoomDAO.Instance.checkStatusRoomisRenting(getRoomCode()) == true) MessageBox.Show("Phòng này đang được cho thuê");
                    else
                    {
                        MessageBox.Show("Phòng này đang được sửa chữa");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Nhập đúng định dạng : Tên Phòng , CMND kiểu số , Loại khách hàng(nội địa,nước ngoài)");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
}
