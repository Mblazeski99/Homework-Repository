using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagment
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 1;
            List<User> selectionList = new List<User>();

            List<User> inputList = new List<User>();
            var Veko = new Admin("Wekoslav", Roles.Admin, inputList);
            var Mio = new Admin("Miodrag", Roles.Admin, inputList);
            var Ivo = new Trainer("Ivo", Roles.Trainer);
            var Viktor = new Trainer("Viktor", Roles.Trainer);
            var Sanja = new Student("Sanja", Roles.Student, Subjects.Cs, 10);
            var Marko = new Student("Marko", Roles.Student, Subjects.Cs, 5);
            inputList.Add(Veko);
            inputList.Add(Mio);
            inputList.Add(Ivo);
            inputList.Add(Viktor);
            inputList.Add(Sanja);
            inputList.Add(Marko);

            Console.WriteLine(@"Press 1 to log in as Admin
2 to log in as Trainer
3 to log in as Student");

           int.TryParse(Console.ReadLine(), out int answer);

            switch(answer)
            {
                case 1:
                    Console.WriteLine("Choose Account");
                    foreach(User user in inputList)
                    {
                        if(user.Role == Roles.Admin)
                        {
                            selectionList.Add(user);
                            Console.WriteLine($"Press {counter} to enter {user.Name}");
                            counter++;
                        }
                    }
                    int.TryParse(Console.ReadLine(), out answer);
                    if(answer - 1 == 0)
                    {
                        Console.WriteLine($"Welcome {selectionList[answer-1].Name}");
                        selectionList[answer - 1].PrintInfo();
                    } else if(answer - 1 == 1)
                        {
                        Console.WriteLine($"Welcome {selectionList[answer - 1].Name}");
                        selectionList[answer - 1].PrintInfo();
                    }
                        break;
                case 2:
                    Console.WriteLine("Choose Account");
                    foreach (User user in inputList)
                    {
                        if (user.Role == Roles.Trainer)
                        {
                            selectionList.Add(user);
                            Console.WriteLine($"Press {counter} to enter {user.Name}");
                            counter++;
                        }
                    }
                    int.TryParse(Console.ReadLine(), out answer);
                    if (answer - 1 == 0)
                    {
                        Console.WriteLine($"Welcome {selectionList[answer - 1].Name}");
                        selectionList[answer - 1].PrintInfo();
                    }
                    else if (answer - 1 == 1)
                    {
                        Console.WriteLine($"Welcome {selectionList[answer - 1].Name}");
                        selectionList[answer - 1].PrintInfo();
                    }
                    break;
                case 3:
                    Console.WriteLine("Choose Account");
                    foreach (User user in inputList)
                    {
                        if (user.Role == Roles.Student)
                        {
                            selectionList.Add(user);
                            Console.WriteLine($"Press {counter} to enter {user.Name}");
                            counter++;
                        }
                    }
                    int.TryParse(Console.ReadLine(), out answer);
                    if (answer - 1 == 0)
                    {
                        Console.WriteLine($"Welcome {selectionList[answer - 1].Name}");
                        selectionList[answer - 1].PrintInfo();
                    }
                    else if (answer - 1 == 1)
                    {
                        Console.WriteLine($"Welcome {selectionList[answer - 1].Name}");
                        selectionList[answer - 1].PrintInfo();
                    }
                    break;
            }









            Console.ReadKey();
        }
    }
}
