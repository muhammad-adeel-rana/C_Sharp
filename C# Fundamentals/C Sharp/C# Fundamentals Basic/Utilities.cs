using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals_Basic
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

        public static void checkingEquality()
        {
            string firstName = "Bethany";

            bool c1 = firstName == "Bethany";
            bool c2 = firstName.Equals("Bethany");

            Console.WriteLine($"{c1}, {c2}");

        }

        public static void parsingStrings()
        {
            Console.WriteLine("Enter the Wage");
            String wage = Console.ReadLine();

            //int wageValue = int.Parse(wage);
            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing Success: " + wageValue);
            else
                Console.WriteLine("Parsing Failed");
        }

        //Void Functions
        //static void calculateYearlyWage(int month, int monthlyWage)
        //{
        //    Console.WriteLine($"Yearly Wage: {month * monthlyWage}");
        //}

        //Int Functions
        public static int calculateYearlyWage(int month, int monthlyWage)
        {
            if (month == 12)
            {
                return (month + 1) * monthlyWage;
            }

            return month * monthlyWage;
        }

        public static int calculateYearlyWage(int month, int monthlyWage, int bonus)
        {
            if (month == 12)
            {
                return month * monthlyWage + bonus;
            }
            return month * monthlyWage;
        }

        //Optional Parameters
        public static int calculateYearlyWageWithOptionalParameters(int month, int monthlyWage, int bonus = 0)
        {
            if (month == 12)
            {
                return month * monthlyWage + bonus;
            }
            return month * monthlyWage;
        }

        //ExpressionBodied
        public static int calculateYearlyWageExpressionBodied(int month, int monthlyWage, int bonus) => month * monthlyWage + bonus;
    }
}
