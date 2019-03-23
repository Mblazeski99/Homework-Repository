using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagment
{
    public class Trainer : User
    {
        public Trainer(string name, Roles role) : base(name, role)
        {

        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} Role: {Role}");
        }
    }
}
