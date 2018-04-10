using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class CustomerStyleDTO
    {
        private int customerStyleCode;
        private string customerStyleName;

        public int CustomerStyleCode
        {
            get
            {
                return customerStyleCode;
            }

            set
            {
                customerStyleCode = value;
            }
        }

        public string CustomerStyleName
        {
            get
            {
                return customerStyleName;
            }

            set
            {
                customerStyleName = value;
            }
        }

        public CustomerStyleDTO() { }
        public CustomerStyleDTO(int customerStyleCode , string customerStyleName)
        {
            this.customerStyleCode = customerStyleCode;
            this.customerStyleName = customerStyleName;
        }
    }
}
