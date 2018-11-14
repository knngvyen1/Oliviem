using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    
    public class LoginMemoryContext /*: ILogincontext*/ /*afdwingen dat je classe alle methodes bevat van de interface*/
    {
        public List<User> users;
        //singleton

        //private static LoginMemoryContext instance;

        //public static LoginMemoryContext getInstance()
        //{
        //    if (instance == null) { instance = new LoginMemoryContext(); }
        //    return instance;
        //}

        //private LoginMemoryContext()
        //{
        //    users = new List<User>();
        //    AddFakeData();
        //}

        public LoginMemoryContext()
        {
            users = new List<User>();
            AddFakeData();

        }
        private void AddFakeData()
        {
            users.Add(new User("karin", "de knapste",5 , 6));
            users.Add(new User("viem", "de lelijkste", 5, 9));
        }


        
        public bool Login(User user)
        {
            bool valid = false;

            //Controleren of er een gebruiker bestaat met het gegeven naam en wachtwoord
            foreach (User u in users)
            {
                if (users!= null)
                {
                    if (u.username == user.username && u.password == user.password)
                    {
                        valid = true;
                        break;
                        
                    }
                }
                else
                {
                    Console.WriteLine("no user found");
                }

            }

            return valid;
        }

        public string login(User user)
        {
            throw new NotImplementedException();
        }
        //welke methodes er staan in de logincontext interfce moet ook in deze classes staan
    }
}
