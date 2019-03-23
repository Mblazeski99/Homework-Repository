using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagment
{
    public class User
    {
        public string Name { get; set; }
        public Roles Role { get; set; }

        public User(string name, Roles role)
        {
            Name = name;
            Role = role;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} Role: {Role}");
        }
    }
}
