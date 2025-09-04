using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Utilities
    {
        public static void usingEscapeChar()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string displayName = $"Welcome! \n{firstName}\t{lastName}";
            Console.WriteLine(displayName);

            string filePath = "C:\\employees\\datalist.xlsx";
            string filePathVerbatim = @"C:\employees\datalist.xlsx";

            string quoted = "It's \"Quaid\" Day";
        }

        public static void checkingEquality() {
            string firstName = "Bethany";

            bool c1 = firstName == "Bethany";
            bool c2 = firstName.Equals("Bethany");

            Console.WriteLine($"{c1}, {c2}");

        }

        public static void parsingStrings() {
            Console.WriteLine("Enter the Wage");
            String wage = Console.ReadLine();

            //int wageValue = int.Parse(wage);
            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing Success: " + wageValue);
            else
                Console.WriteLine("Parsing Failed");
        }
    }
}
