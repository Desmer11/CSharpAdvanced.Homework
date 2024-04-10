using Class05.Exercise01.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Exercise01.Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public Fish(string name, int age, string color,int size) : base(name, PetType.Fish.ToString(), age) 
        {
            Size = size;
            Color = color;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"\n{Name}" +
                $"\nType: {Type.ToString()}" +
                $"\nAge: {Age}" +
                $"\nColor: {Color}" +
                $"\nSize: {Size}");
        }
    }
}
