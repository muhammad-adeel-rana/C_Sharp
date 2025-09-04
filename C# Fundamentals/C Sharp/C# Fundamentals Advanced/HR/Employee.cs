using C__Fundamentals_Advanced.Contracts;
using C__Fundamentals_Advanced.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects.HR
{
    public class Employee:IEmployee
    {

        #region Fields
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate; // Nullable Type
        private const int minimalHourofWorkUnit = 1;

        private DateTime birthDay;
        private Address address;

        public static double taxRate = 0.15;
        #endregion

        #region Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            protected set { numberOfHoursWorked = value; }
        }

        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set {
                if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion

        #region Constructors
        public Employee(string firstName, string lastName, string email, DateTime birthDay) : this(firstName,
            lastName, email, birthDay, 0)
        {

        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10; //If rate is null set it to 10
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate,
            string street, string houseNumber, string zipCode, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10; //If rate is null set it to 10
            Address = new Address(street, houseNumber, zipCode, city);
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
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s)!");
        }

        public double RecieveWage(bool resetHours = true)
        {
            double wageBeforeTax = 0.0;
            //if (employeeType == EmployeeType.Manager)
            //{
            //    Console.WriteLine($"An extra was added to the wage as {firstName} is a manager!");
            //    wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value * 1.25;
            //}
           
            wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;

            double taxAmount = wageBeforeTax * taxRate;
            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t{Email}\nBirthday: \t{BirthDay.ToShortDateString()}" +
                $"\nTax Rate\t{taxRate}");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked >= 10)
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
            if (NumberOfHoursWorked >= 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee get the bonus of {bonus} and bonus tax is {bonusTax}");
            return bonus;
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You have done a great job! {FirstName}");
        }
        #endregion

        #region Virtual Methods
        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a genric bonus of 100!");
        }

        #endregion
    }
}
