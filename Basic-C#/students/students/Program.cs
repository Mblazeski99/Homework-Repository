using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] StudentArray = new Student[5];

            StudentArray[0] = new Student("Marko", "SEDC", "G4");
            StudentArray[1] = new Student("Nikola", "SEDC", "G4");
            StudentArray[2] = new Student("Venko", "SEDC", "G4");
            StudentArray[3] = new Student("Milena", "SEDC", "G4");
            StudentArray[4] = new Student("Kristina", "SEDC", "G4");

            bool stop = false;
            bool found = true;
            char answer;


            while (stop == false)
            {
                Console.WriteLine("\n Search Students? (Y/N)");

                answer = Console.ReadKey().KeyChar;

                if (answer == 'y' || answer == 'Y')
                {
                    Console.WriteLine("\n Enter Student name:");

                    string inputName = Console.ReadLine();

                    foreach (Student element in StudentArray)
                    {
                        if (inputName == element.Name)
                        {
                            Console.WriteLine(element.ShowStats());
                        } else
                        {
                            found = false;
                        }
                    }
                    if (found == false)
                    {
                        Console.WriteLine("That student does not exist!");
                    }
                } else
                {
                    stop = true;
                }
            }
            

                
            



            Console.ReadKey();
        }
    }
}