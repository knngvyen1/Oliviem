using Factory;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLIVIEM.DAL;
using OLIVIEM.Logic;
using OLIVIEM.Models;
using System;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class UnitTesten
    {
        private Account user;
        private Accountlogic accountLogic;
        private Registerlogic registerLogic;
        private Loginlogic loginlogic;
        private Random random = new Random();
        private string GenerateRandomUser()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [TestInitialize]
        public void Initialize()
        {
            accountLogic = Factory.Factory.GetAccountlogic();
            registerLogic = Factory.Factory.GetRegisterlogic();
            loginlogic = Factory.Factory.GetLoginLogic();

            user = new Account()
            {
                name = "Karin",
                gender = "Woman",
                id = 1,
                lastname = "Nguyen",
                dateofbirth = new DateTime(1980, 12, 1),
                saldo = 100,
                password = "12345678",
                username = "heyyyyy"
            };
        }
   
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Create_User_Where_Password_Less_Than_8()
        {
            user.password = "1234567";
            registerLogic.AddUser(user);
        }

        [TestMethod]
        public void Create_User_Password_More_Than_7()
        {
            user.username = GenerateRandomUser();
            user.password = "12345679";
            registerLogic.AddUser(user);
        }

        [TestMethod]
        public void CreateUserPasswordMoreThan8()
        {
            user.username = GenerateRandomUser();
            user.password = "12345679";
            registerLogic.AddUser(user);
        }

        [TestMethod]
        public void UserLoginWhereSucceed()
        {
            user.username = "Karin";
            user.password = "eten12345";
            Assert.IsTrue(loginlogic.LogIn(user.username, user.password));
        }

    }


}
