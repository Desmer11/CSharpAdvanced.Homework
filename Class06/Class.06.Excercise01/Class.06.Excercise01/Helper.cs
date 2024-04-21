using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._06.Excercise01
{
    public static class ListHelper
    {
        public static void Print<T>(this List<T> list) where T : BaseEntity
        {
            Console.WriteLine("Printing..");
            foreach (T item in list)
            {
                item.PrintInfo();
            }
            Console.WriteLine("...\n");
        }
    }
}
