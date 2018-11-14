using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public int id { get; set; }
        public double saldo { get; set; }

        public User(string Username, string Password, int Id, double Saldo)
        {
            username = Username;
            password = Password;
            id = Id;
            saldo = Saldo;

        }

        public User()
        {

        }

        public User(string Username, string Password)
        {
            username = Username;
            password = Password;
        }


    }
}
