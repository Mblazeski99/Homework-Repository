using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosePrize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1 to 3");
            int.TryParse(Console.ReadLine(), out int InputNumber);
            switch(InputNumber)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("You get nothing good day sir!");
                        break;
            }

            Console.ReadKey();
        }
    }
}
