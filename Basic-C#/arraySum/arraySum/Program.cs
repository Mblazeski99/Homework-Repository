using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] sumArray = new int[5];
            for(int i = 0; i<=4; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                if(int.TryParse(Console.ReadLine(), out sumArray[i]))
                {
                    sum += sumArray[i];
                } else
                {
                    Console.WriteLine("you did not enter a number");
                    break;
                }
                
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"the sum of all numbers is {sum}");


            Console.ReadKey();
        }
    }
}
