using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Task1.Domain
{
    public static class UserDatabase
    {
        public static List<User> UserData { get; set; }
        static UserDatabase()
        {
            UserData = new List<User>()
            {
                new User("Caesar",24,1),
                new User("Aura",20,2),
                new User("Kiro",22,3)
            };
        }
        public static List<User> Search(string inputName = "", int inputID = -1, int inputAge = -1)
        { 
            List<User> users = new List<User>();
            foreach (var item in UserData)
            {
                if (inputName == item.name || inputID == item.id || inputAge == item.age)
                {
                    users.Add(item);
                    Console.WriteLine($"Name: {item.name} Age: {item.age} ID: {item.id}");
                }
            }
            return users;
        }
    }
}
