﻿using QuanLyKhachSan.DAO;
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
    public partial class fAddRoom : Form
    {
        private fRoom _fRoom;
      
        RoomDTO _room = new RoomDTO(); 
        public fAddRoom(fRoom form)
        {
            InitializeComponent();
            _fRoom = form;
            txbRoomCode.Select(); // focus cusor in textbox : CodeName
            setDataStyleRoom();
        }
        
        #region set
        private void setDataStyleRoom() 
        {
            cbxStyleRoom.DisplayMember = "TenLoaiPhong";
            cbxStyleRoom.ValueMember = "MaLoaiPhong";
            cbxStyleRoom.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataStyleRoomQuery());
        }

      
        private void cbxStyleRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStyleRoom.SelectedItem != null)
            {
                DataRowView drv = cbxStyleRoom.SelectedItem as DataRowView;
                _room.RoomStyle = int.Parse(cbxStyleRoom.SelectedValue.ToString());
                string query = RoomDAO.Instance.cbxstyleRoom_SelectIndexQuery() + _room.RoomStyle;
                txbPrice.Text = DataProvide.Instance.ExecuteReader(query); // hien thi don gia theo StyleRoom
            }
        }
        #endregion

        #region get
        private RoomDTO getCodeRoom()
        {
            _room.RoomCode = int.Parse(txbRoomCode.Text.ToString());
            return _room;
        }
        private RoomDTO getNameRoom()
        {
            _room.RoomName = txbRoomName.Text.ToString();
            return _room;
        }
       
        private RoomDTO getNoteRoom()
        {
            _room.RoomNote = txbNote.Text.ToString();
            return _room;
        }
        #endregion


        private void button1_Click(object sender, EventArgs e) // button add
        {

            try
            {
               int data = DataProvide.Instance.ExecuteNonQuery(RoomDAO.Instance.addRoomDatabaseQuery(), new object[] { getCodeRoom().RoomCode, getNameRoom().RoomName, _room.RoomStyle, getNoteRoom().RoomNote });
                if (data < 0)
                {
                    MessageBox.Show("Thêm phòng thành công");
                    _fRoom.LoadRoomList();
                }
            }
            catch(Exception ex)
            {
                if(ex is SqlException)
                {
                    MessageBox.Show("Mã phòng đã tồn tại");
                }else
                {
                    MessageBox.Show("Nhập mã phòng sai");
                }
            }
            
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}