using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04.Task01.Shapes
{
    public class Shape
    {
        public string id {  get; set; }

        public virtual void GetArea()
        {
            Console.WriteLine("No Implementation of Area");
        }
        public virtual void GetPerimeter()
        {
            Console.WriteLine("No Implementation of Perimeter");
        }

    }
}
