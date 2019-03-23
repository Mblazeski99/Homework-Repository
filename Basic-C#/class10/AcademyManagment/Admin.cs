using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagment
{
    public class Admin : User
    {       
        public List<User> Admins_Trainers { get; set; }

        public Admin(string name, Roles role, List<User> admin_Trainers) : base(name, role)
        {
            Admins_Trainers = admin_Trainers;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} Role: {Role}");
        }

    }
}
