using Class._02.Exercise01.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._02.Exercise01.Domain.Models
{
    public class Teacher : User, ITeacher
    {
        public Teacher(string firstName, string lastName, string userName, string password, string subject)
            : base(firstName, lastName, userName, password)
        {
            Subject = subject;
        }

        public string Subject { get; set; }

        public void PrintSubject()
        {
            Console.WriteLine($"The current subject is {Subject}.");
        }

        public void PrintSubjects()
        {
            Console.WriteLine($"The current subject is {Subject}.");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Teacher {FirstName} {LastName} teaches {Subject}");
        }
    }
}
