using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Employee
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public double Salary { get; protected set; }
        public Role Role { get; protected set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}
