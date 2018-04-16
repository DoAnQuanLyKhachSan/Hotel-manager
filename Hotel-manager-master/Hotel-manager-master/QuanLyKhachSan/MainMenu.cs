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
        private object resources;
        List<Button> Buttonlist = new List<Button>();
        public MainMenu()
        {
            InitializeComponent();
            LoadRoom();
            LoadStatusOfRooms();
            LoadListRoom();
        }
        #region Method
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
            foreach(Button btn in Buttonlist)
            {
                if(button.Text==btn.Text)
                {
                    Buttonlist.Remove(btn);
                    break;
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
                        if(control.Text==roomDTO.RoomName)
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
            flpStatus.Controls.Add(btnAll);
            flpStatus.Controls.Add(btnAv);
            flpStatus.Controls.Add(btnIU);
            flpStatus.Controls.Add(btnMT);
        }
        public void LoadListRoom()
        {
            string query = "select PHONG.MaPhong from PHONG";
            string[] data = DataProvide.Instance.ExecuteReader(query).Split(' ');
            this.textBox1.AutoCompleteCustomSource.AddRange(data);
        }
        #endregion
        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int RoomCode = ((sender as Button).Tag as RoomDTO).RoomCode;
            this.Hide();
            fViewRoom fView = new fViewRoom(LoadRoomInfo(RoomCode), RoomCode, this);
            fView.ShowDialog();
            this.Show();
        }

        public List<BillInfoDTO> LoadRoomInfo(int roomcode)
        {
            List<BillInfoDTO> ListBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetBillIDByRoomcode(roomcode));
            return ListBillInfo;
        }
        private void btnAll_Click(object sender,EventArgs args)
        {
            MessageBox.Show("btnAll");
        }
        private void btnAv_Click(object sender, EventArgs args)
        {
            MessageBox.Show("btnAv");
        }
        private void btnIU_Click(object sender, EventArgs args)
        {
            MessageBox.Show("btnIU");
        }
        private void btnMT_Click(object sender, EventArgs args)
        {
            MessageBox.Show("btnMT");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Height = RoomButton.Height;
            panel1.Top = RoomButton.Top;
            this.Hide();
            fRoom _room = new fRoom(this);
            _room.ShowDialog();            
            this.Show();         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Height = PayButton.Height;
            panel1.Top = PayButton.Top;
            this.Hide();
            string mess = "Thanh toán phòng theo tên khách hàng ?";
            string caption = "Hình thức thanh toán";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mess, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                fPayView1 f = new fPayView1();
                f.ShowDialog();
            }else
            {
                fPay f = new fPay();
                f.ShowDialog(); 
            }
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Height = ReportButton.Height;
            panel1.Top = ReportButton.Height;
            this.Hide();
            fReport _room = new fReport();
            _room.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Height = AboutUsButton.Height;
            panel1.Height = AboutUsButton.Top;
            this.Hide();
            WindowsFormsApp5.Form1 _room = new WindowsFormsApp5.Form1();
            _room.ShowDialog();
            this.Show();
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
            this.Hide();
            fLogin _room = new fLogin();
            this.Show();
            _room.ShowDialog();

        }
        #endregion

        private void ChangeRegulationButton_Click(object sender, EventArgs e)
        {
            panel1.Height = ChangeRegulationButton.Height;
            panel1.Height = ChangeRegulationButton.Top;
            fChangeRegulations f = new fChangeRegulations();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

    }
}

