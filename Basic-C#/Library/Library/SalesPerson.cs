using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class SalesPerson : Employee
    {
        public double SuccesSalesRevenue { get; private set; }
        public double Bonus { get; private set; }

        public SalesPerson()
        {
            FirstName = "John";
            LastName = "Matrix";
            Salary = 1500;
            Role = Role.Sales;
        }

        public void AddSuccessRevenue(double value)
        {
            SuccesSalesRevenue = value;
        }

        public override double GetSalary()
        {
           if(SuccesSalesRevenue <= 2000)
            {
                Bonus = 500;
            } else if(SuccesSalesRevenue > 2000 || SuccesSalesRevenue <= 5000)
            {
                Bonus = 1000;
            } else if(SuccesSalesRevenue > 5000)
            {
                Bonus = 1500;
            }

            Console.WriteLine("Salary With bonus:");
            return Salary + Bonus;
        }
    }
}
