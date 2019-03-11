using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    class Student
    {
        public string Name; /*{ get; set; }*/
        public string Academy; /*{ get; set; }*/
        public string Group; /*{ get; set; }*/


        public Student(string Name, string Academy, string Group)
        {
            this.Name = Name;
            this.Academy = Academy;
            this.Group = Group;
        }

        public string ShowStats ()
        {
            return $@"
Name: {Name} 
Academy: {Academy} 
Group: {Group}";
        }
    }
}
