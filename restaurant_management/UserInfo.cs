using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management
{
    public class UserInfo
    {
        bool isLogin;
        String role;
        String username;
        String iD;



        private static UserInfo instance;
        public static UserInfo Instance
        {
            get { if (instance == null) { return instance = new UserInfo(); } return instance; }
            private set => instance = value;
        }

        public bool IsLogin { get => isLogin; set => isLogin = value; }
        public string Role { get => role; set => role = value; }
        public string Username { get => username; set => username = value; }
        public string ID { get => iD; set => iD = value; }

        private UserInfo() { }
    }
}
