using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string FirstInput = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string SecondInput = Console.ReadLine();
            string EvenOdd1;
            string EvenOdd2;
            if (!(int.TryParse(FirstInput, out int FirstNumber)))
            {
                Console.WriteLine("You did not enter a number");
            }
            else
            {
                if (!(int.TryParse(SecondInput, out int SecondNumber)))
                {
                    Console.WriteLine("You did not enter a number");
                }
                else
                {
                    if(FirstNumber % 2 == 0)
                    {
                        EvenOdd1 = "Even";
                    } else
                    {
                        EvenOdd1 = "Odd";
                    }

                    if (SecondNumber % 2 == 0)
                    {
                        EvenOdd2 = "Even";
                    }
                    else
                    {
                        EvenOdd2 = "Odd";
                    }

                    if (FirstNumber == SecondNumber)
                    {
                        Console.WriteLine($"both numbers {FirstNumber} and {SecondNumber} are equal and they are both {EvenOdd1} numbers");
                    } else if(FirstNumber > SecondNumber)
                    {
                        Console.WriteLine($"the larger number is {FirstNumber} and it is an {EvenOdd1} number");
                    } else
                    {
                        Console.WriteLine($"the larger number is {SecondNumber} and it is an {EvenOdd2} number");
                    }

                }
                Console.ReadKey();
            }
        }
    }
}
