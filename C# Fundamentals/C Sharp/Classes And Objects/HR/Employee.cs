using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects.HR
{
    internal class Employee
    {
        #region Fields
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double? hourlyRate; // Nullable Type
        const int minimalHourofWorkUnit = 1;

        public DateTime birthDay;

        public EmployeeType_Enum employeeType;

        public static double taxRate = 0.15;

        #endregion

        #region Constructors
        public Employee(string first, string last, string em, DateTime bd) : this(first,
            last, em, bd, 0, EmployeeType_Enum.StoreManager)
        {

        }

        public Employee(string first, string last, string mail, DateTime bd, double? rate, EmployeeType_Enum empType)
        {
            firstName = first;
            lastName = last;
            email = mail;
            birthDay = bd;
            hourlyRate = rate ?? 10; //If rate is null set it to 10
            employeeType = empType;
        }
        #endregion

        #region Methods
        public void PerformWork()
        {
            //numberOfHoursWorked++;
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
            PerformWork(minimalHourofWorkUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }

        public double RecieveWage(bool resetHours = true)
        {
            double wageBeforeTax = 0.0;
            if (employeeType == EmployeeType_Enum.Manager)
            {
                Console.WriteLine($"An extra was added to the wage as {firstName} is a manager!");
                wageBeforeTax = numberOfHoursWorked * hourlyRate.Value * 1.25;

            }
            else
            {
                wageBeforeTax = numberOfHoursWorked * hourlyRate.Value;
            }

            double taxAmount = wageBeforeTax * taxRate;
            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t{email}\nBirthday: \t{birthDay.ToShortDateString()}" +
                $"\nTax Rate\t{taxRate}");
        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked >= 10)
                bonus += 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        //public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        //{
        //    if (numberOfHoursWorked >= 10)
        //        bonus *= 2;

        //    if (bonus >= 200)
        //    {
        //        bonusTax = bonus/10;
        //        bonus -= bonusTax;
        //    }

        //    Console.WriteLine($"The employee get the bonus of {bonus} and bonus tax is {bonusTax}");
        //    return bonus;
        //}

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (numberOfHoursWorked >= 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee get the bonus of {bonus} and bonus tax is {bonusTax}");
            return bonus;
        }

        #endregion

    }
}
