using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            void makeXmasTree()
            {
                string stars = "*";
                int emptySpaces = 10;
                string tree = "";
                for (int i = 0; i < 10; i++)
                {
                    tree = "";
                    for (int j = emptySpaces; j > 0; j--)
                    {
                        tree += " ";
                    }
                    emptySpaces--;
                    tree += stars;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(tree);
                    stars += "**";
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("         ||");
                Console.WriteLine("         ||");
                Console.WriteLine("         ||");
                Console.WriteLine("         ||");
                Console.ReadKey();
            }
            makeXmasTree();
        }
    }
}
