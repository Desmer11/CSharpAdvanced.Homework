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
        public string Subject { get; set; }
        public Teacher(string subject,string firstname, string lastname, string username, string password)
            : base(firstname, lastname, username, password)
        {
            Subject = subject;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Teacher {Firstname} {Lastname} \nTeaches: {Subject}");
            
        }
        public void PrintSubject()
        {
            Console.WriteLine($"Subject is: {Subject}");
        }
    }
}
