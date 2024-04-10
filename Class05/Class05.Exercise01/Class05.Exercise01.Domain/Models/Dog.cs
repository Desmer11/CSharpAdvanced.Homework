using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class05.Exercise01.Domain.Enums;

namespace Class05.Exercise01.Domain.Models
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"\n{Name}" +
                $"\nType: {Type.ToString()}" +
                $"\nAge: {Age}" +
                $"\nFavourite Food: {FavouriteFood}");
        }
        public Dog (string name,int age, string favouriteFood) : base(name, PetType.Dog.ToString(), age)
        {
            FavouriteFood = favouriteFood;
        }
    }
}
