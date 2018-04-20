using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class UserDTO
    {
        private string userName;
        private string userPass;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string UserPass
        {
            get
            {
                return userPass;
            }

            set
            {
                userPass = value;
            }
        }
        public UserDTO() { }
        public UserDTO(string userName,string userPass)
        {
            this.userName = userName;
            this.userPass = userPass;
        }
    }
}
