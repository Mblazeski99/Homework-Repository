using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagment
{
    public class Student : User
    {
        public Subjects CurrentSubject { get; set; }
        public int SubjectGrade { get; set; }

        public Student(string name, Roles role, Subjects currentSubject, int subjectGrade) : base(name, role)
        {
            CurrentSubject = currentSubject;
            SubjectGrade = subjectGrade;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} Role: {Role} Current Subject: {CurrentSubject} Subject Grade: {SubjectGrade}");
        }
    }
}
