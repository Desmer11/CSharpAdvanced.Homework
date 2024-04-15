using Class._06.Excercise01;
using Class._06.Excercise01.Models;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

List<string> firstnames = Database.People.Where(x => x.Firstname.StartsWith("R"))
    .OrderByDescending(x => x.Age)
    .Select(x => x.Firstname)
    .ToList();

foreach(string firstname in firstnames)
{
    Console.WriteLine(firstname);
}


// Find all the names and ages of brown dogs older than 3 ordered by age.

List<string> brownDogs =Database.Dogs.Where(x => x.Color == "Brown" && x.Age > 3)
                                     .OrderBy(x => x.Age)
                                     .Select(x => $"Name: {x.Name} Age: {x.Age}")
                                     .ToList();
foreach (string dog in brownDogs)
{
    Console.WriteLine(dog);
}








Console.WriteLine("=====");

// Find Freddys Dogs older than 1 year.

Person freddy = Database.People.First(x => x.Firstname == "Freddy");
List<Dog> freddysDogs = freddy.Dogs;
List<string> freddysDogsNames = freddysDogs.Where
    (x => x.Age > 1).Select(x => x.Name).ToList();

foreach(string  name in freddysDogsNames)
{
    Console.WriteLine($"Dogs older than 1 : {name}");
}


// Nathans First Dog

Person nathen = Database.People.FirstOrDefault(x => x.Firstname == "Nathen");
if(nathen != null)
{

    //Dog firstDog = nathen.Dogs[0];
    Dog firstDog2 = nathen.Dogs.FirstOrDefault();
    if(firstDog2 == null)
    {
        Console.WriteLine("No Dogs");
    }
    else
    {
        Console.WriteLine($"Nathens first dog is: {firstDog2.Name}");
    }
}


// Find and print all white dogs from Cristofer, Freddy, Erin, Amelia
// Ord. Name

List<Person> fourPeople = Database.People.Where(x =>
x.Firstname == "Cristofer" ||
x.Firstname == "Freddy" ||
x.Firstname == "Erin" ||
x.Firstname == "Amelia").ToList();
foreach(Person p in fourPeople)
{
    Console.WriteLine(p);
}

List<Dog> dogs = fourPeople.SelectMany(x => x.Dogs).ToList();
List<string> names = dogs.Where(x =>x.Color == "White")
    .OrderBy(x => x.Name)
    .Select(x => x.Name).ToList();

foreach(string name in names)
{
    Console.WriteLine($"White Dogs From People:{fourPeople} Dogs: "+name);
};