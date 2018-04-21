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
        fViewRoom fview;
<<<<<<< HEAD:Hotel-manager-master_17-4v4/Hotel-manager-master_16-4 - Copy/Hotel-manager-master/Hotel-manager-master/Hotel-manager-master/QuanLyKhachSan/fRent.cs
        MainMenu m = new MainMenu(1);
        public fRent(fRoom room, string roomname,MainMenu mainMenu)
=======
        public fRent(fRoom room, string roomname, MainMenu mainMenu)
>>>>>>> 79bd8ce4d26160fc385df522e155bfc60d43b97e:Hotel-manager-master/QuanLyKhachSan/fRent.cs
        {
            InitializeComponent();
            m = mainMenu;
            this.txbRoomName.Text = roomname;
            f = room;
            loadComboBoxInDataGridView();
        }

        public fRent(fRoom room)
        {
            InitializeComponent();
<<<<<<< HEAD:Hotel-manager-master_17-4v4/Hotel-manager-master_16-4 - Copy/Hotel-manager-master/Hotel-manager-master/Hotel-manager-master/QuanLyKhachSan/fRent.cs
            //f = room;
=======
            // f = room;
>>>>>>> 79bd8ce4d26160fc385df522e155bfc60d43b97e:Hotel-manager-master/QuanLyKhachSan/fRent.cs
            loadComboBoxInDataGridView();
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

        private void loadComboBoxInDataGridView()
        {
            customerStyle.MaxDropDownItems = 4;
            customerStyle.ValueMember = "TenLoaiKhachHang";
            customerStyle.DataSource = DataProvide.Instance.ExecuteQuery("select TenLoaiKhachHang from LOAI_KHACHHANG ");
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoomDAO.Instance.checkStatusRoomisRent(getRoomCode()) == true)  // nếu phòng có thể cho thuê thì trả về true
<<<<<<< HEAD:Hotel-manager-master_17-4v4/Hotel-manager-master_16-4 - Copy/Hotel-manager-master/Hotel-manager-master/Hotel-manager-master/QuanLyKhachSan/fRent.cs
                {
                    getInforCustomer();// tạo một danh sách đối tượng khách hàng thuê phòng
                    RoomDAO.Instance.CreateTenancyCard(getRoomCode(), getBeginDay());//tao phieu thue phong
                    RoomDAO.Instance.CreateTenancyCardDetail(_customer, getRoomCode(), getBeginDay());//tao chitiet-thuephong
                     
                    MessageBox.Show("Tạo phiếu thuê phòng thành công");
                    LoadListRoomAndCloseForm();
                    m.ReLoadRoomStatus();
                    m.AddCustomerToBox(_customer[0].CustomerName);
                    fViewRoom t = new fViewRoom(m.LoadRoomInfo(getRoomCode()), m.LoadRoomInfor(getRoomCode()), getRoomCode(), m);
                    fview = new fViewRoom(t);
                }
                else   // phòng đang sửa chữa hoặc đang cho thuê
                {
=======
                {
                    getInforCustomer();// tạo một danh sách đối tượng khách hàng thuê phòng
                    RoomDAO.Instance.CreateTenancyCard(getRoomCode(), getBeginDay());//tao phieu thue phong
                    RoomDAO.Instance.CreateTenancyCardDetail(_customer, getRoomCode(), getBeginDay());//tao chitiet-thuephong

                    MessageBox.Show("Tạo phiếu thuê phòng thành công");
                    LoadListRoomAndCloseForm();
                    m.ReLoadRoomStatus();
                    m.ReLoadStatusOfRooms();
                    m.AddCustomerToBox(_customer[0].CustomerName);
                    fViewRoom t = new fViewRoom(m.LoadRoomInfo(getRoomCode()), m.LoadRoomInfor(getRoomCode()), getRoomCode(), m);
                    fview = new fViewRoom(t);
                }
                else   // phòng đang sửa chữa hoặc đang cho thuê
                {
>>>>>>> 79bd8ce4d26160fc385df522e155bfc60d43b97e:Hotel-manager-master/QuanLyKhachSan/fRent.cs
                    if (RoomDAO.Instance.checkStatusRoomisRenting(getRoomCode()) == true) MessageBox.Show("Phòng này đang được cho thuê");
                    else
                    {
                        MessageBox.Show("Phòng này đang được sửa chữa");
                    }
                }

<<<<<<< HEAD:Hotel-manager-master_17-4v4/Hotel-manager-master_16-4 - Copy/Hotel-manager-master/Hotel-manager-master/Hotel-manager-master/QuanLyKhachSan/fRent.cs
=======
            }
>>>>>>> 79bd8ce4d26160fc385df522e155bfc60d43b97e:Hotel-manager-master/QuanLyKhachSan/fRent.cs
            catch (Exception)
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
