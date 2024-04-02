using Class._02.Exercise01.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._02.Exercise01.Domain.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades{ get; set; }
        
        public Student(string firstname, string lastname, string username, string password,List<int> grades)
            : base(firstname, lastname, username, password)
        {
            Grades = Grades != null ? grades : new List<int>();

        }
        public override void PrintUser()
        {
            Console.WriteLine($"Student {Firstname} {Lastname}" +
                $"Grades: {Grades}");
            foreach(int grade in Grades)
            {
                Console.Write(grade);
            }
            
        }

        public double GetAverageGrade()
        {
            throw new NotImplementedException();
        }
    }
}
