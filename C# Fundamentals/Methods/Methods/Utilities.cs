using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Utilities
    {
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
