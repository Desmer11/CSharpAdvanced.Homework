using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class04.Task01.Shapes
{
    public class Rectangle : Shape
    {
        public int SideA;
        public int SideB;
        
        public Rectangle () { }


        public override void GetPerimeter()
        {
            int perimeter = 2 * (SideA + SideB);
            Console.WriteLine($"Name: {id} - Perimeter: {perimeter}");
        }

        public override void GetArea()
        {
            int area = SideA + SideB;
            Console.WriteLine($"Name: {id} - Area: {area}");
        }
        public void PrintInfo()
        {
            Console.WriteLine
                ("Name: " + id + 2 +
                "\nSide A: " + SideA +
                "\nSide B:" + SideB);
        }
    }
}
