using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public bool CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
       

    }
}
