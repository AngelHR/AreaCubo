using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ar;
            Console.WriteLine("Dime cuanto mide el lado de un cubo para sacar su Area:");
            n = int.Parse(Console.ReadLine());

            ar = n * n * n;

            Console.WriteLine($"El Area del cubo Dado es : {ar}");

            Console.ReadKey();
        }
    }
}
