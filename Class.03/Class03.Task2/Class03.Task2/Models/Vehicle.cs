using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Task2.Models
{
    public abstract class Vehicle
    {
        public string name { set; get; }
        public int wheels { set; get; }
        public Vehicle() { }
        public Vehicle(string name,int wheels)
        {
            name = string.Empty;
            wheels = 0;

        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"");
        }


    }
}
