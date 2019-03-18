using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Manager : Employee
    {
        public double Bonus { get; private set; }

        public Manager()
        {
            FirstName = "Dylan";
            LastName = "Johnson";
            Role = Role.Manager;
            Salary = 15000;
        }

        public void AddBonus(double value)
        {
            Bonus = value;
        }

        public override double GetSalary()
        {
            Console.WriteLine("Salary With bonus:");
            return Salary + Bonus;
        }
    }    
}
