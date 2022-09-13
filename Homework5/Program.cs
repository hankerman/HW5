using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Market a = new Market(40.5);
            Market b = new Market(30.5);

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a.Square);
            a = a + 40.5;
            Console.WriteLine(a.Square);
            a = a - 20.0;
            Console.WriteLine(a.Square);

        }
    }
}
