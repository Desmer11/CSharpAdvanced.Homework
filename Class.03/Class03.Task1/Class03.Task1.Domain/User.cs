namespace Class03.Task1.Domain
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public User () 
        {
            //this.id = new Random().Next(1,99);
            this.name = string.Empty;
        }
        public User(string name,int age, int id) 
        {
            //this.id = new Random().Next(1,99);
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{id} {name} {age}");
        }

    }
}