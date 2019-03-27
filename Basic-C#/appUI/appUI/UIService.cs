using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI
{
    public class UIService
    {
        private LogicService _logicService = new LogicService();
        public int LoginChoice()
        {
            int choice = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a role to login:");
                Console.WriteLine("1) Admin");
                Console.WriteLine("2) Trainer");
                Console.WriteLine("3) Student");
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (isNumber && choice > 0 && choice < 4) // previously this line was if(isNumber) so the missing code was added to fix the issue
                {
                    break;
                }
                Console.WriteLine("The input should be number and from the options that are given. Press anything to try again...");
                Console.ReadLine();
            }
            return choice;
        }

        public User LoginForm(List<User> database)
        {
            User user;
            while (true)
            {
                Console.Clear();
                Console.Write("Username:");
                string username = Console.ReadLine();
                Console.Write("Password:");
                string password = Console.ReadLine(); // Console.Readline() was added twice so i removed it so that it only requires one entry for password
                user = _logicService.LogIn(username, password, database);
                if (user != null)
                {
                    break;
                }
                Console.WriteLine("Press anything to try again...");
                Console.ReadLine();
            }
            return user;
        }
        public int AdminChoice(User user) // AdminChoice as well as TrainerChoice and StudentChoice method now require a User paramater
        {
            int choice = 0;
            while (true)
            {
                if(user.Role != Role.Admin) // added this if() to check whether the account is the selected role
                {
                    Console.WriteLine($"{user.Username} is not an Admin account you can't use this function");
                    break;
                }
                Console.Clear();
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1) Add User");
                Console.WriteLine("2) Remove User");
                Console.WriteLine("3) Show Users"); // added Show Users
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (isNumber && choice > 0 && choice < 4) // increased betwen 0 to 3 to betwen 0 to 4 so that Show Users can be selected
                {
                    break;
                }
                Console.WriteLine("The input should be number and from the options that are given. Press anything to try again...");
                Console.ReadLine();
            }
            return choice;
        }

        public int TrainerChoice(User user)
        {
            int choice = 0;
            while (true)
            {
                if (user.Role != Role.Trainer) // added this if() to check whether the account is the selected role
                {
                    Console.WriteLine($"{user.Username} is not a Trainer account you can't use this function");
                    break;
                }
                Console.Clear();
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1) Show Students");
                Console.WriteLine("2) Show Subjects");
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (isNumber && choice > 0 && choice < 3)
                {
                    break;
                }
                Console.WriteLine("The input should be number and from the options that are given. Press anything to try again...");
                Console.ReadLine();
            }
            return choice;
        }
        public int StudentChoice(User user)
        {
            int choice = 0;
            while (true)
            {
                if (user.Role != Role.Student) // added this if() to check whether the account is the selected role
                {
                    Console.WriteLine($"{user.Username} is not a Student account you can't use this function");
                    break;
                }
                Console.Clear();
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1) Enrol Class");
                Console.WriteLine("2) Show Grades");
                Console.WriteLine("3) Average Grades");
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (isNumber && choice > 0 && choice < 4)
                {
                    break;
                }
                Console.WriteLine("The input should be number and from the options that are given. Press anything to try again...");
                Console.ReadLine();
            }
            return choice;
        }
        public int ChooseUser(List<User> students)
        {
            int choice = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please choose one:");
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {students[i].FirstName} {students[i].LastName}");
                }
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (isNumber && choice > 0 && choice < students.Count + 1)
                {
                    break;
                }
                Console.WriteLine("The input should be number and from the options that are given. Press anything to try again...");
                Console.ReadLine();
            }
            return choice;
        }
        public int ChooseSubject(List<Subject> subjects)
        {

            int choice = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please choose one:");
                for (int i = 0; i < subjects.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {subjects[i].Title}");
                }
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (isNumber && choice > 0 && choice < subjects.Count + 1)
                {
                    break;
                }
                Console.WriteLine("The input should be number and from the options that are given. Press anything to try again...");
                Console.ReadLine();
            }
            return choice;
        }
        public User AddUserForm()
        {
            Console.WriteLine("First Name:");
            string first = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string last = Console.ReadLine();
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string pass = Console.ReadLine();
            int roleChoice = 0;
            while (true)
            {
                Console.WriteLine("Role:");
                Console.WriteLine("1) Admin");
                Console.WriteLine("2) Trainer");
                Console.WriteLine("3) Student");
                bool isNumber = int.TryParse(Console.ReadLine(), out roleChoice);
                if (isNumber && roleChoice > 0 && roleChoice < 4)
                {
                    break;
                }
                Console.WriteLine("The input should be number and from the options that are given. Press anything to try again...");
                Console.ReadLine();
                Console.Clear();
            }
            Role role = Role.Student;
            if (roleChoice == 1) role = Role.Admin;
            if (roleChoice == 2) role = Role.Trainer;
            return new User(first, last, username, pass, role);
        }

        public void ShowStudents(List<User> students)
        {
            Console.Clear();
            Console.WriteLine("These are all the students:");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadLine();
        }

        public void ShowSubjects(List<Subject> subjects)
        {
            Console.Clear();
            Console.WriteLine("These are all the subjects:");
            foreach (Subject subject in subjects)
            {
                Console.WriteLine($"{subject.Title} ({subject.EnroledStudents.Count} students)");
            }
            Console.ReadLine();
        }
    }
}