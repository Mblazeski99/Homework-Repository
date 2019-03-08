using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char answer;
            string longestName;
            byte[] asciiArray;
            string[] nameArray = new string[0];
            List<string> outputArray = new List<string>();
            for (int i = 0; i <= nameArray.Length; i++)
            {
                Console.WriteLine("\n Do you want to enter a name? (Y/N):");
                answer = Console.ReadKey().KeyChar;

                if(answer == 'y' || answer == 'Y')
                {
                    Array.Resize(ref nameArray, nameArray.Length + 1);

                    Console.WriteLine("\n Enter a name:");
                    nameArray[i] = Console.ReadLine();                    
                } else
                {
                    Console.WriteLine("\n I'll take that as a no");

                    for (int j = 97; j <= 122; j++)
                    {
                        foreach(string name in nameArray)
                        {
                            asciiArray = Encoding.ASCII.GetBytes(name);
                            if(asciiArray[0] == j)
                            {
                                outputArray.Add(name);
                            }
                        }
                    }


                    longestName = outputArray[0];

                    foreach(string outputName in outputArray)
                    {
                        Console.WriteLine(outputName);
                        if(outputName.Length > longestName.Length)
                        {
                            longestName = outputName;
                        }
                    }
                    
                    Console.WriteLine($"the longest name is {longestName}");
                }
            }

            Console.ReadKey();
        }
    }
}
