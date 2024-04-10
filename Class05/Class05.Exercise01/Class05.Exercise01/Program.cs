e

using Class05.Exercise01.Domain;
using Class05.Exercise01.Domain.Models;
using Class05.Exercise01.Domain.Enums;

PetStore <Dog> dogPetStore = new PetStore<Dog> ();
dogPetStore.Pets.Add(new Dog("Barkie", 3, "Bacon"));
Console.WriteLine("Dogs in Datatbase");
dogPetStore.PrintPets();
dogPetStore.BuyPet("Barkie");




PetStore<Cat> catPetStore = new PetStore<Cat>();
catPetStore.Pets.Add(new Cat("Kiro", 3, false, 9));
Console.WriteLine("Cats in Datatbase");
catPetStore.PrintPets();
catPetStore.BuyPet("Kiro");



PetStore<Fish> fishPetStore = new PetStore<Fish>();
fishPetStore.Pets.Add(new Fish("Fish", 3, "Red", 10 ));
Console.WriteLine("Dogs in Datatbase");
fishPetStore.PrintPets();
fishPetStore.BuyPet("Fish");









