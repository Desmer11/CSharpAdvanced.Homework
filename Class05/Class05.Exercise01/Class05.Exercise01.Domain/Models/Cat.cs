using Class05.Exercise01.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Exercise01.Domain.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, int age, bool isLazy, int livesLeft) : base(name, PetType.Cat.ToString(), age)
        {
            IsLazy = isLazy;
            LivesLeft = livesLeft;
        
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"\nName: {Name} " +
                $"\nType: {Type.ToString()}" +
                $"\nLives: {LivesLeft}");
            if (IsLazy)
            {
                Console.WriteLine("The Cat is Lazy");
            }
            else
            {
                Console.WriteLine("The Cat is Productive");
            }
        }
    }
}
