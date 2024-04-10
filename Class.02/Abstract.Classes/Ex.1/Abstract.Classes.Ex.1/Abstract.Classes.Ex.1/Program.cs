using System.ComponentModel.DataAnnotations;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract classes = Modifier that indicates 
            // Missing or incomplete implementation

            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();
            // Cannot create an object directly from abstract 
            //Vehicle vehicle = new Vehicle();
            Console.ReadKey();
        }
    }
    abstract class Vehicle
    {
        public int speed = 0;
        public void Go()
        {
            Console.WriteLine("The Vehicle is Moving");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 250;
    }
    class Bike : Vehicle
    {
        public int wheels = 2;
        int maxSped = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }

}













