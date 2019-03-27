using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI
{
    public class LogicService
    {
        public User LogIn(string userName, string password, List<User> users)
        {
            try
            {
                var found = users.Where(x => x.Username == userName).First();                
                var passFound = users.Where(x => x.Password == password).First(); // added passFound so it checks if the password is correct as well, previously it would return true regardless of what you entered
                return found;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("User Does not exists or you have entered the wrong password!");
                return null;
            }
        }
    }
}