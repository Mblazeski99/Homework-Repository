using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            void ageCalculator()
            {
                int age = 0;
                DateTime currentDate = DateTime.Now;

                Console.WriteLine("Enter your birthday (dd/MM/yyyy):");
                DateTime birthday = Convert.ToDateTime(Console.ReadLine());
                age = currentDate.Year - birthday.Year;
                Console.WriteLine($"Your birthday: Day: {birthday.Day} Month: {birthday.Month} Year: {birthday.Year}");
                Console.WriteLine($"Current date: Day: {currentDate.Day} Month: {currentDate.Month} Year: {currentDate.Year}");

                if (currentDate.Month == birthday.Month)
                {
                    if(currentDate.Day < birthday.Day)
                    {
                        age -= 1;
                    }
                } else if (currentDate.Month < birthday.Month)
                {
                    age -= 1;
                }

                Console.WriteLine($@"----------------------
you are {age} years olds");               
            }

            ageCalculator();




            Console.ReadKey();
        }
        
    }
}
