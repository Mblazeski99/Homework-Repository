using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var SalesMan = new SalesPerson();
            Console.WriteLine("The sales guys info is:");
            SalesMan.PrintInfo();
            SalesMan.AddSuccessRevenue(3500);
            Console.WriteLine(SalesMan.GetSalary());

            var ManagerMan = new Manager();
            Console.WriteLine("The manager guys info is:");
            ManagerMan.PrintInfo();
            ManagerMan.AddBonus(5000);
            Console.WriteLine(ManagerMan.GetSalary());


            Console.ReadKey();
        }
    }
}
