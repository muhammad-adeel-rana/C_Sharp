using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator4._7._2Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hex = Globomentics.Math.Calculator.AsHex(255);
            Console.WriteLine(hex);
            Console.ReadLine();
        }
    }
}
