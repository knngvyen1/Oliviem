using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLIVIEM.Viewmodel
{
    public class RegisterViewmodel
    {
        public int Id { get; set; }
        public bool registration;
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Saldo { get; set; }   
        public string message { get; set; }

    }
}
