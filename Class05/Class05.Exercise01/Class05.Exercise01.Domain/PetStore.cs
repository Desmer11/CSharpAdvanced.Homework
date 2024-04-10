using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class05.Exercise01.Domain;
using Class05.Exercise01.Domain.Models;

namespace Class05.Exercise01.Domain
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets { get; set;}
        public PetStore() 
        {
            Pets = new List<T>();
        }
        public void PrintPets()
        {
            foreach(T pet in Pets)
            {
                pet.PrintInfo();
            }
        }
        public void BuyPet(string name)
        {
            T petDB = Pets.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
            if (petDB == null)
            {
                Console.WriteLine("There is no Pet: ");
                return;
            }
            Pets.Remove(petDB);
            Console.WriteLine("The Pet was Bought");
        }
    }
}
