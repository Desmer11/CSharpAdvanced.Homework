using Class._06.Excercise01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._06.Excercise01.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public Breed Breed { get; set; }
        public Dog(string name, string color, int age,Breed breed ) 
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;
            this.Breed = breed;

        }
    }
}
