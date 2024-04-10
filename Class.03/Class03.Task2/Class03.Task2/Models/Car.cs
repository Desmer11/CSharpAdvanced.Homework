using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Task2.Models
{
    public class Car : Vehicle
    {
        public Car() { }
        public Car(string name, int wheels) : base(name, wheels)
        {

        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"I am a {name} And I drive on {wheels} wheels");
        }
    }
}
