using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class04.Task01.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle() { }

        public override void GetPerimeter()
        {
            double perimeter = Math.PI * 2 * Radius;
            Console.WriteLine($"Name: {id} - Perimeter: {perimeter}");
        }

        public override void GetArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Name: {id} - Area: {area}");
        }

        public void PrintInfo()
        {
            Console.WriteLine
                ("Name: " + id +
                "\nRadius. " + Radius);
        }
    }
}
