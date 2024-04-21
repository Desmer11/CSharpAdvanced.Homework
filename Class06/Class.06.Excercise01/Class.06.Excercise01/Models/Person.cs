using Class._06.Excercise01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._06.Excercise01.Models
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Job Job { get; set; }
        public List<Dog> Dogs { get; set; }
        public Person(string firstname,string lastname, int age,Job job)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Job = job;
            Dogs = new List<Dog>();

        }
    }
}
