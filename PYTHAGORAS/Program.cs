using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYTHAGORAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pythagoras");
            Console.WriteLine("Bestem a^2");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Bestem b^2");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"c^2 = {(a * a) + (b * b)}");
            Console.ReadKey();
        }
    }
}
