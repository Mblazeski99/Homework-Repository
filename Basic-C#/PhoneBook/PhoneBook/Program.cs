using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName;
            bool found = false;
            bool stop = false;
            char answer;

            Dictionary<string, int> PhoneBook = new Dictionary<string, int>()
            {
                {"Marko", 263},
                {"Dejan", 243},
                {"Venko", 253 },
                {"Nikola", 439},
                {"Sanja", 325}
            };


            do
            {
                Console.WriteLine(" Enter the name of the person you are looking for:");
                inputName = Console.ReadLine();

                foreach (string key in PhoneBook.Keys)
                {
                    if (inputName == key || inputName == key.ToLower())
                    {
                        found = true;
                        Console.WriteLine($@"The Phone Number of {inputName} is {PhoneBook[key]}
Continue? (Y/N)");
                        answer = Console.ReadKey().KeyChar;
                        if (answer == 'N' || answer == 'n' )
                        {
                            Console.WriteLine("o");
                            stop = true;
                        }
                        else
                        {
                            Console.WriteLine("es");
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine($"The Phonebook does not contain {inputName} try again? (Y/N)");
                        answer = Console.ReadKey().KeyChar;
                        if (answer == 'N' || answer == 'n')
                        {
                            Console.WriteLine("o");
                            stop = true;
                        }
                        else
                        {
                            Console.WriteLine("es");
                        }
                    }
                }

            } while (stop == false);

            
            


            Console.ReadKey();
        }
    }
}
