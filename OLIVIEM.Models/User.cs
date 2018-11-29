using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public DateTime dateofbirth { get; set; }
        public string gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public double saldo { get; set; }

        public User(string Name, string Lastname, DateTime DateOfbirth, string Gender, string Username, string Password, double Saldo)
        {
            name = Name;
            lastname = Lastname;
            dateofbirth = DateOfbirth;
            gender = Gender;
            username = Username;
            password = Password;
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
        public User(string Username)
        {
            username = Username;
        }


    }
}
