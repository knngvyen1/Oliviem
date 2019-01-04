using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Models
{
   public class Account
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public DateTime dateofbirth { get; set; }
        public string gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public decimal saldo { get; set; }


        public Account(string Name, string Lastname, DateTime DateOfbirth, string Gender, string Username, string Password, decimal Saldo)
        {
            name = Name;
            lastname = Lastname;
            dateofbirth = DateOfbirth;
            gender = Gender;
            username = Username;
            password = Password;
            saldo = Saldo;
           
        }

        public Account()
        {

        }

        public Account(string Username, string Password)
        {
            username = Username;
            password = Password;
        }
        public Account(string Username)
        {
            username = Username;
        }
    }
}
