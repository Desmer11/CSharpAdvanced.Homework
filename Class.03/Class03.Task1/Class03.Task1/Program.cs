using Class03.Task1.Domain;




User user = new User();

UserDatabase.Search("Caesar");
UserDatabase.Search(inputAge: 10);

string userInput = Console.ReadLine();
//int inputAsInt = Convert.ToInt32(userInput);

UserDatabase.Search(userInput);