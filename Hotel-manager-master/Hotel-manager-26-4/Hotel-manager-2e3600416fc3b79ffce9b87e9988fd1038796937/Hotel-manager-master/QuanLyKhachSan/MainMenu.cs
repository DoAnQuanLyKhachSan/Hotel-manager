using QuanLyKhachSan;
using System;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
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
    public partial class MainMenu : Form
    {
        List<Button> Buttonlist = new List<Button>();
        List<Button> InfoButtonlist = new List<Button>();
        fLogin fLoginCurrent = new fLogin();
        public MainMenu(fLogin f=null)
        {
            InitializeComponent();
            LoadRoom();
            LoadStatusOfRooms();
            LoadListRoom();
            fLoginCurrent = f;
            AddCustomerToBox();
        }
        public MainMenu()
        {
            //do nothing
        }
        #region Method
        private int getGroupCode()
        {
            string query = "select MaNhom from NGUOI_DUNG where TenDangNhap = N'" + fLoginCurrent.getUser().UserName + "'";
            return int.Parse(DataProvide.Instance.ExecuteReader(query));
        }
        public void ReloadRoom(string[] change)
        {
            SuspendLayout();                                //        0         1       2       3       4       5       6
            /*String[] change = ChangedValue.Split('@');*/ //change{oldcode,oldname,newcode,newname,newnote,newstyle,newstatus}
            foreach (Button btn in Buttonlist)
            {
                if (btn.Text == change[1])
                {
                    btn.Text = change[3];
                }
            }
            ResumeLayout();
        }
        public void ReloadRoomImage(string[] change)
        {
            SuspendLayout();                            //        0         1       2       3       4       5       6
            /*String[] change = ChangedValue.Split('@');*/ //change{oldcode,oldname,newcode,newname,newnote,newstyle,newstatus}
            foreach (Button btn in Buttonlist)
            {
                if (btn.Text == change[3])
                {
                    switch (change[5])
                    {
                        case "1":
                            btn.Image = global::QuanLyKhachSan.Properties.Resources.room1;
                            break;
                        case "2":
                            btn.Image = global::QuanLyKhachSan.Properties.Resources.room2;
                            break;
                        case "3":
                            btn.Image = global::QuanLyKhachSan.Properties.Resources.room3;
                            break;
                        default:
                            break;
                    }
                    break;
                }
            }
            ResumeLayout();
        }
        public void AddRoom(Button button)
        {
            SuspendLayout();
            flpRoom.Controls.Add(button);
            Buttonlist.Add(button);
            ResumeLayout();
        }
        public void RemoveRoom(Button button)
        {
            SuspendLayout();
            List<Control> listControls = flpRoom.Controls.Cast<Control>().ToList();

            foreach (Control control in listControls)
            {
                if (button.Text == control.Text && control.GetType() == typeof(Button))
                {
                    flpRoom.Controls.Remove(control);
                    control.Dispose();
                    break;
                }
            }
            foreach (Button btn in Buttonlist)
            {
                if (button.Text == btn.Text)
                {
                    Buttonlist.Remove(btn);
                    break;
                }
            }
            ResumeLayout();
        }

        public void RemoveAllRoom()
        {
            SuspendLayout();
            List<Control> listControls = flpRoom.Controls.Cast<Control>().ToList();

            foreach (Control control in listControls)
            {
                foreach (Button btn in Buttonlist)
                {
                    if (btn.Text == control.Text && control.GetType() == typeof(Button))
                    {
                        flpRoom.Controls.Remove(control);
                        control.Dispose();
                        break;
                    }
                }
            }
           
            ResumeLayout();
        }


        public void ReLoadRoomStatus()
        {
            List<RoomDTO> StatusRoomList = RoomDAO.Instance.LoadRoomList();

            foreach (Button control in Buttonlist)
            {
                if (control.GetType() == typeof(Button))
                {
                    //all btn
                    foreach (RoomDTO roomDTO in StatusRoomList)
                    {
                        if (control.Text == roomDTO.RoomName)
                        {
                            switch (roomDTO.RoomStatus)
                            {
                                case 1:
                                    control.BackColor = Color.LightPink;
                                    break;
                                case 2:
                                    control.BackColor = Color.LightGray;
                                    break;
                                case 3:
                                    control.BackColor = Color.OrangeRed;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        }
                    }
                }
            }
        }

        public void LoadRoom()
        {
            List<RoomDTO> RoomList = RoomDAO.Instance.LoadRoomList();
            foreach (RoomDTO roomDTO in RoomList)
            {

                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeigh };
                btn.Text = roomDTO.RoomName;
                btn.Click += new EventHandler(btn_Click);
                btn.Tag = roomDTO;
                switch (roomDTO.RoomStyle)
                {
                    case 1:
                        btn.Image = global::QuanLyKhachSan.Properties.Resources.room1;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        break;
                    case 2:
                        btn.Image = global::QuanLyKhachSan.Properties.Resources.room2;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        break;
                    case 3:
                        btn.Image = global::QuanLyKhachSan.Properties.Resources.room3;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        break;
                    default:
                        break;
                }
                switch (roomDTO.RoomStatus)
                {
                    case 1:
                        btn.BackColor = Color.LightPink;
                        break;
                    case 2:
                        btn.BackColor = Color.LightGray;
                        break;
                    case 3:
                        btn.BackColor = Color.OrangeRed;
                        break;
                    default:
                        break;
                }
                Buttonlist.Add(btn);
                flpRoom.Controls.Add(btn);
            }
        }
        //public void ReleaseFlowlayoutPanel()
        //{
        //    List<Control> listControls = flpRoom.Controls.Cast<Control>().ToList();

        //    foreach (Control control in listControls)
        //    {
        //        flpRoom.Controls.Remove(control);
        //        control.Dispose();
        //    }
        //}
        public void ReLoadStatusOfRooms()
        {
            SuspendLayout();
            int Total = 0, available = 0, inused = 0, undermaintainance = 0;
            List<RoomDTO> StatusRoomList = RoomDAO.Instance.LoadRoomList();
            foreach (RoomDTO roomDTO in StatusRoomList)
            {
                //btn.Text = roomDTO.RoomName;               
                switch (roomDTO.RoomStatus)
                {
                    case 1:
                        available += 1;
                        break;
                    case 2:
                        inused += 1;
                        break;
                    case 3:
                        undermaintainance += 1;
                        break;
                    default:
                        break;
                }

            }
            Total = available + inused + undermaintainance;
            InfoButtonlist[0].Text = "Tất Cả " + Total.ToString();
            InfoButtonlist[1].Text = "Có Thể Thuê " + available.ToString();
            InfoButtonlist[2].Text = "Đã Thuê " + inused.ToString();
            InfoButtonlist[3].Text = "Đang Sửa Chữa " + undermaintainance.ToString();
            ResumeLayout();
        }
        public void LoadStatusOfRooms()
        {
            int Total = 0, available = 0, inused = 0, undermaintainance = 0;
            List<RoomDTO> StatusRoomList = RoomDAO.Instance.LoadRoomList();
            foreach (RoomDTO roomDTO in StatusRoomList)
            {
                //btn.Text = roomDTO.RoomName;               
                switch (roomDTO.RoomStatus)
                {
                    case 1:
                        available += 1;
                        break;
                    case 2:
                        inused += 1;
                        break;
                    case 3:
                        undermaintainance += 1;
                        break;
                    default:
                        break;
                }

            }
            Total = available + inused + undermaintainance;
            //All
            Button btnAll = new Button() { Width = 100, Height = 25 };
            btnAll.Text = "Tất Cả " + Total.ToString();
            btnAll.BackColor = Color.White;
            btnAll.Click += new EventHandler(btnAll_Click);
            btnAll.Width = 125;
            btnAll.Height = 50;
            //Available
            Button btnAv = new Button() { Width = 100, Height = 25 };
            btnAv.Text = "Có Thể Thuê " + available.ToString();
            btnAv.BackColor = Color.LightPink;
            btnAv.Click += new EventHandler(btnAv_Click);
            btnAv.Width = 125;
            btnAv.Height = 50;
            //Inused
            Button btnIU = new Button() { Width = 100, Height = 25 };
            btnIU.Text = "Đã Thuê " + inused.ToString();
            btnIU.BackColor = Color.LightGray;
            btnIU.Click += new EventHandler(btnIU_Click);
            btnIU.Width = 125;
            btnIU.Height = 50;
            //Undermaintainance
            Button btnMT = new Button() { Width = 100, Height = 25 };
            btnMT.Text = "Đang Sửa Chữa " + undermaintainance.ToString();
            btnMT.BackColor = Color.OrangeRed;
            btnMT.Click += new EventHandler(btnMT_Click);
            btnMT.Width = 125;
            btnMT.Height = 50;
            InfoButtonlist.Add(btnAll);
            InfoButtonlist.Add(btnAv);
            InfoButtonlist.Add(btnIU);
            InfoButtonlist.Add(btnMT);
            flpStatus.Controls.Add(btnAll);
            flpStatus.Controls.Add(btnAv);
            flpStatus.Controls.Add(btnIU);
            flpStatus.Controls.Add(btnMT);
        }
        public void LoadListRoom()
        {
            string roomquery = "select PHONG.MaPhong from PHONG";
            if (DataProvide.Instance.ExecuteReaderString(roomquery) != null)
            {
                string[] roomdata = DataProvide.Instance.ExecuteReaderString(roomquery).Split('@');

                this.textBox1.AutoCompleteCustomSource.AddRange(roomdata);
            }

        }
        public void AddCustomerToBox()
        {
            string[] namedata = { };
            string namequery = "select Tenkhachhang from CHITIET_PHIEUTHUE";
            if (DataProvide.Instance.ExecuteReaderString(namequery) != null)
                namedata = DataProvide.Instance.ExecuteReaderString(namequery).Split('@');
            this.textBox1.AutoCompleteCustomSource.Clear();
            this.textBox1.AutoCompleteCustomSource.AddRange(namedata);
        }
        #endregion
        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int RoomCode = ((sender as Button).Tag as RoomDTO).RoomCode;
            this.Hide();
            BillDTO billDTO;
            fViewRoom fView;
            if (LoadRoomDTO(RoomCode).Count != 0)
            {
                billDTO = LoadRoomDTO(RoomCode).First();
                fView = new fViewRoom(LoadRoomInfo(RoomCode), LoadRoomInfor(RoomCode), RoomCode, this, billDTO.PayStatus1);
            }
            else
            {
                fView = new fViewRoom(LoadRoomInfo(RoomCode), LoadRoomInfor(RoomCode), RoomCode, this);
            }
            fView.ShowDialog();
            this.Show();
            this.AddCustomerToBox();
        }

        public List<BillInfoDTO> LoadRoomInfo(int roomcode)
        {
            List<BillInfoDTO> ListBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetBillIDByRoomcode(roomcode));
            return ListBillInfo;
        }
        public List<BillInfoDTO> LoadRoomInfo(string customername)
        {
            List<BillInfoDTO> ListBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetBillIDByCustomerName(customername));
            return ListBillInfo;
        }
        public List<BillDTO> LoadRoomDTO(int roomcode)
        {
            List<BillDTO> ListBillInfo = BillDAO.Instance.GetListBillInfo(roomcode);
            return ListBillInfo;
        }
        public RoomDTO LoadRoomInfor(int roomcode)
        {
            RoomDTO room = BillDAO.Instance.GetRoomInfoByRoomcode(roomcode);
            return room;
        }
        public CustomerDTO LoadRoomInfor(string customername)
        {
            CustomerDTO room = BillDAO.Instance.GetRoomInfoByCustomerName(customername);
            return room;
        }
        private void btnAll_Click(object sender, EventArgs args)
        {
            MessageBox.Show("btnAll");
        }
        private void btnAv_Click(object sender, EventArgs args)
        {
            this.Hide();
            fRoomClassifiedByStyle _room = new fRoomClassifiedByStyle(this, 1);
            _room.ShowDialog();
            this.Show();
        }
        private void btnIU_Click(object sender, EventArgs args)
        {
            this.Hide();
            fRoomClassifiedByStyle _room = new fRoomClassifiedByStyle(this, 2);
            _room.ShowDialog();
            this.Show();
        }
        private void btnMT_Click(object sender, EventArgs args)
        {
            this.Hide();
            fRoomClassifiedByStyle _room = new fRoomClassifiedByStyle(this, 3);
            _room.ShowDialog();
            this.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fRoom") == true)
            {
                this.Hide();
                fRoom _room = new fRoom(fLoginCurrent);
                _room.ShowDialog();
                this.RemoveAllRoom();
                this.LoadRoom();
                this.ReLoadStatusOfRooms();
                this.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            CustomerDTO Temp = LoadRoomInfor(this.textBox1.Text);
            if (Temp != null)
            {
                this.Hide();
                fViewRoom fView = new fViewRoom(LoadRoomInfo(Temp.Roomcode), LoadRoomInfor(Temp.Roomcode), this);
                fView.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Khách Hàng");
            }
            this.Show();
            this.AddCustomerToBox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fPayInfo") == true)
            {
                this.Hide();
                fPayInfo f = new fPayInfo();
                this.RemoveAllRoom();
                this.LoadRoom();
                f.ShowDialog();
                this.Show();
                this.ReLoadRoomStatus();
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fReport") == true)
            {
                this.Hide();
                fReport _room = new fReport();
                _room.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "AboutUs") == true)
            {
                this.Hide();
                WindowsFormsApp5.Form1 _room = new WindowsFormsApp5.Form1();
                _room.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }


        private void flpRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fAccountManagement") == true)
            {
                this.Hide();
                fAccountManagement f = new fAccountManagement();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");

        }
      

        private void ChangeRegulationButton_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fChangeRegulations") == true)
            {
                fChangeRegulations f = new fChangeRegulations();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fService") == true)
            {
                fService f = new fService(); 
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (AccountManagementDAO.Instance.checkShowForm(getGroupCode(), "fStaff") == true)
            {
                fStaff f = new fStaff();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không có quyền truy cập");
        }
        #endregion
    }
}

