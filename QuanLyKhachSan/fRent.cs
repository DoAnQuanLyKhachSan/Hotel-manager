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
    public partial class fRent : Form
    {
        CustomerDTO[]  _customer = new CustomerDTO[5];
       


        public fRent()
        {
            InitializeComponent();

        }

        public void getInforCustomer()
        {
            int i = 0;
            
            foreach (DataGridViewRow row in dtgvInputCustomes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    _customer[i] = new CustomerDTO();
                    _customer[i].CustomerCode = CustomerDAO.Instance.createMaxCustomerCodeToDataBase()+i;
                    _customer[i].CustomerName = row.Cells[0].Value.ToString();
                    _customer[i].CustomerStyle = CustomerDAO.Instance.returnCustomerStyleCode(row.Cells[1].Value.ToString());
                    _customer[i].CustomerCMND = int.Parse(row.Cells[2].Value.ToString());
                    _customer[i].CustomerAddress = row.Cells[3].Value.ToString();
                    i++;
                  
                }
            }
        }



        private void btnAccept_Click(object sender, EventArgs e)
        {
            getInforCustomer();
           
        }
    }
}
